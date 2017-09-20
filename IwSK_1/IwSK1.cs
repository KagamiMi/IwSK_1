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
        public IwSK1()
        {
            InitializeComponent();
            var list = SerialPort.GetPortNames();
            portComboBox.DataSource = list;
            portComboBox.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
