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
        private List<string> dataField = new List<string>(new string[] {"7-bitowe","8-bitowe"});
        private List<string> control = new List<string>(new string[] {"E (parzystość)","O (nieparzystość)","N (brak)"});
        private List<string> stopBits = new List<string>(new string[] {"1 bit","2 bity"});
        private List<string> flowControl = new List<string>(new string[] {"Brak kontroli przepływu","Sprzętowa - handshake DTR/DSR",
        "Sprzętowa - handshake RTS/CTS", "Programowa - XON/XOFF"});
        private List<string> terminator = new List<string>(new string[] {"Brak terminatora","Terminator standardowy CR","Terminator standardowy LF",
        "Terminator standardowy CR-LF", "Terminator własny 1-znakowy", "Terminator własny 2-znakowy"});
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
        }
    }
}
