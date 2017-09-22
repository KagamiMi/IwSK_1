using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

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
        private List<string> terminator = new List<string>(new string[] {"Brak terminatora","Terminator standardowy CR","Terminator standardowy LF",
        "Terminator standardowy CR-LF", "Terminator własny 1-znakowy", "Terminator własny 2-znakowy"});

        SerialPort port;
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
            terminatorComboBox.DataSource = terminator;
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
                        SerialPort portToCheck = new SerialPort(portComboBox.Text);
                        if (!portToCheck.IsOpen)
                        {
                            if (port.IsOpen)
                            {
                                if (portComboBox.Text != port.PortName)
                                {
                                    port.Close();
                                }
                                configure(speed);
                            }
                            else
                            {
                                configure(speed);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Port nie może być otworzony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "  Zła wartość szybkości");
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

            port = new SerialPort(portComboBox.SelectedValue.ToString(), speed, parity, dataBits, stopBits);
            port.Handshake = handshake;
            port.DataReceived += new SerialDataReceivedEventHandler(dataReceivedHandler);
            port.Open();
            communicationPanel.Enabled = true;
        }

        public void transmitButton_Click(object sender, EventArgs args)
        {
            //MessageBox.Show("transmit button trial");
            port.Write(transmitedDataTextBox.Text);
            transmitedDataTextBox.Text = "";
        }

        private void setText(string text)
        {
            receivedDataTextBox.Text = text;
        }

        private void dataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort senderPort = (SerialPort)sender;
            string receivedData = senderPort.ReadExisting();
            if (this.receivedDataTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                this.Invoke(d, receivedData);
            }
            else
            {
                receivedDataTextBox.Text = receivedData;
            }
        }
    }
}
