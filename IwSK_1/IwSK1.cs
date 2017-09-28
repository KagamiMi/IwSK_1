using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace IwSK_1
{
    public partial class IwSK1 : Form
    {
        delegate void SetTextCallback(string text);
        private List<string> dataField = new List<string>(new string[] { "7-bitowe", "8-bitowe" });
        private List<string> control = new List<string>(new string[] { "E (parzystość)", "O (nieparzystość)", "N (brak)" });
        private List<string> stopBits = new List<string>(new string[] { "1 bit", "2 bity" });
        private List<string> flowControl = new List<string>(new string[] {"Brak kontroli przepływu","Sprzętowa - handshake DTR/DSR",
        "Sprzętowa - handshake RTS/CTS", "Programowa - XON/XOFF"});
        private List<string> terminators = new List<string>(new string[] {"Brak terminatora","Terminator standardowy CR","Terminator standardowy LF",
        "Terminator standardowy CR-LF"});
        Stopwatch pingPongTimer = new Stopwatch();
        string PING = "#";
        string PONG = "$";

        SerialPort port;
        Terminator terminator;
        public IwSK1()
        {
            InitializeComponent();
            var list = SerialPort.GetPortNames();
            portComboBox.DataSource = list;
            portComboBox.SelectedIndex = -1;
            dataFieldComboBox.DataSource = dataField;
            dataFieldComboBox.SelectedIndex = -1;
            controlComboBox.DataSource = control;
            controlComboBox.SelectedIndex = -1;
            stopBitsComboBox.DataSource = stopBits;
            stopBitsComboBox.SelectedIndex = -1;
            flowControlComboBox.DataSource = flowControl;
            flowControlComboBox.SelectedIndex = -1;
            terminatorComboBox.DataSource = terminators;
            terminatorComboBox.SelectedIndex = -1;
            communicationPanel.Enabled = false;
            port = new SerialPort();
            //pytanie ogolne: 
            //co sie stanie gdy rozne parametry polaczenia damy na dwoch komputerach?
        }

        public void configureButton_Click(object sender, EventArgs args)
        {
            if ((portComboBox.SelectedIndex == -1) || (dataFieldComboBox.SelectedIndex == -1) || (controlComboBox.SelectedIndex == -1) ||
                (stopBitsComboBox.SelectedIndex == -1) || (flowControlComboBox.SelectedIndex == -1) || (terminatorComboBox.SelectedIndex == -1))
            {
                MessageBox.Show("Nie wybrano wszystkich parametrów konfiguracji");
            }
            else
            {
                int speed;
                try
                {
                    speed = Int32.Parse(speedTextBox.Text);
                    if (speed < 150)
                    {
                        MessageBox.Show("Zbyt mała szybkość, minimalna szybkość to 150 bit/s");
                    }
                    else if (speed > 117760)
                    {
                        MessageBox.Show("Zbyt duża szybkość, maksymalna szybkość to 117 760 bit/s");
                    }
                    else
                    {
                        //MessageBox.Show("Konfigurujemy");
                        //zablokowanie comboboxow na czas wykonania konfiguracji
                        //poki nie jest dobra konfiguracja, nie udostepniamy reszty okien
                        if (port != null)
                        {
                            port.Close();
                        }
                        configure(speed);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
        }

        public void configure(int speed)
        {
            Parity parity;
            switch (controlComboBox.SelectedValue.ToString())
            {
                case ("E (parzystość)"):
                    parity = Parity.Even;
                    break;
                case ("O (nieparzystość)"):
                    parity = Parity.Odd;
                    break;
                case ("N (brak)"):
                    parity = Parity.None;
                    break;
                default:
                    parity = Parity.None;
                    break;
            }
            int dataBits;
            switch (dataFieldComboBox.SelectedValue.ToString())
            {
                case ("7-bitowe"):
                    dataBits = 7;
                    break;
                case ("8-bitowe"):
                    dataBits = 8;
                    break;
                default:
                    dataBits = 7;
                    break;
            }
            StopBits stopBits;
            switch (stopBitsComboBox.SelectedValue.ToString())
            {
                case ("1 bit"):
                    stopBits = StopBits.One;
                    break;
                case ("2 bity"):
                    stopBits = StopBits.Two;
                    break;
                default:
                    stopBits = StopBits.One;
                    break;
            }
            Handshake handshake;
            switch (flowControlComboBox.SelectedIndex)
            {
                case (0):
                    handshake = Handshake.None;
                    break;
                case (1):
                    handshake = Handshake.RequestToSendXOnXOff;
                    break;
                case (2):
                    handshake = Handshake.RequestToSend;
                    break;
                case (3):
                    handshake = Handshake.XOnXOff;
                    break;
                default:
                    handshake = Handshake.None;
                    break;
            }

            switch (terminatorComboBox.SelectedIndex)
            {
                case (0):
                    terminator = Terminator.None;
                    break;
                case (1):
                    terminator = Terminator.CR;
                    break;
                case (2):
                    terminator = Terminator.LF;
                    break;
                case (3):
                    terminator = Terminator.CRLF;
                    break;
                default:
                    terminator = Terminator.None;
                    break;
            }

            port = new SerialPort(portComboBox.SelectedValue.ToString(), speed, parity, dataBits, stopBits);
            port.Handshake = handshake;
            port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
            port.ErrorReceived += new SerialErrorReceivedEventHandler(errorRecivedHandler);
            port.Open();
            communicationPanel.Enabled = true;
        }

        public void transmitButton_Click(object sender, EventArgs args)
        {
            //MessageBox.Show("transmit button trial");
            port.Write(transmitedDataTextBox.Text + GetTerminatorSymbols(terminator));
            transmitedDataTextBox.Text = "";
        }

        private void setText(string text)
        {
            receivedDataTextBox.Text += text;
        }
        private void setPingPongTime(string time)
        {
            pingPongTextBox.Text = time;
        }

        private void dataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort senderPort = (SerialPort)sender;
            string receivedData = senderPort.ReadExisting();
            if (receivedData.Trim() == PING)
            {
                SendPong();
            }
            else if (receivedData.Trim() == PONG && pingPongTimer.IsRunning)
            {
                ConsumePong();
            }
            else if (this.receivedDataTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                this.Invoke(d, receivedData);
            }
            else
            {
                receivedDataTextBox.Text += receivedData;
            }
        }
        private void errorRecivedHandler(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.EventType.ToString());
        }

        public string GetTerminatorSymbols(Terminator terminator)
        {
            switch (terminator)
            {
                case Terminator.None:
                    return "";
                case Terminator.CRLF:
                    return "\r\n";
                case Terminator.LF:
                    return "\n";
                case Terminator.CR:
                    return "\r";
                default:
                    return "";
            }
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            pingPongTimer.Start();
            port.Write(PING + GetTerminatorSymbols(terminator));
            pingButton.Enabled = false;
        }
        private void SendPong()
        {
            port.Write(PONG + GetTerminatorSymbols(terminator));
        }
        private void ConsumePong()
        {
            double pingPongTime = pingPongTimer.Elapsed.TotalMilliseconds;
            pingPongTimer.Stop();
            pingPongTimer.Reset();
            pingPongTime = Math.Round(pingPongTime, 2);
            string formatedTime = pingPongTime.ToString() + " ms";
            SetPingTextBoxText(formatedTime);
            EnablePingButton();
        }
        private void EnablePingButton()
        {
            if (this.pingButton.InvokeRequired)
            {
                this.Invoke((Action)(() => pingButton.Enabled = true));
            }
            else
            {
                pingButton.Enabled = true;
            }
        }

        private void SetPingTextBoxText(string formatedTime)
        {
            if (this.receivedDataTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setPingPongTime);
                this.Invoke(d, formatedTime);
            }
            else
            {
                receivedDataTextBox.Text = formatedTime;
            }
        }

        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            this.receivedDataTextBox.Text = "";
        }
    }

    public enum Terminator { None, CRLF, LF, CR }

}
