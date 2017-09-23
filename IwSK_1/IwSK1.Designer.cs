namespace IwSK_1
{
    partial class IwSK1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.transmitedDataTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receivedDataTextBox = new System.Windows.Forms.TextBox();
            this.transmitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.configureButton = new System.Windows.Forms.Button();
            this.terminatorComboBox = new System.Windows.Forms.ComboBox();
            this.flowControlComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.controlComboBox = new System.Windows.Forms.ComboBox();
            this.dataFieldComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.communicationPanel = new System.Windows.Forms.Panel();
            this.pingButton = new System.Windows.Forms.Button();
            this.pingPongTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.communicationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transmitedDataTextBox
            // 
            this.transmitedDataTextBox.Location = new System.Drawing.Point(7, 42);
            this.transmitedDataTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transmitedDataTextBox.Multiline = true;
            this.transmitedDataTextBox.Name = "transmitedDataTextBox";
            this.transmitedDataTextBox.Size = new System.Drawing.Size(234, 140);
            this.transmitedDataTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nadawanie: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odbieranie: ";
            // 
            // receivedDataTextBox
            // 
            this.receivedDataTextBox.Enabled = false;
            this.receivedDataTextBox.Location = new System.Drawing.Point(282, 42);
            this.receivedDataTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receivedDataTextBox.Multiline = true;
            this.receivedDataTextBox.Name = "receivedDataTextBox";
            this.receivedDataTextBox.Size = new System.Drawing.Size(198, 140);
            this.receivedDataTextBox.TabIndex = 2;
            // 
            // transmitButton
            // 
            this.transmitButton.Location = new System.Drawing.Point(8, 186);
            this.transmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transmitButton.Name = "transmitButton";
            this.transmitButton.Size = new System.Drawing.Size(82, 21);
            this.transmitButton.TabIndex = 4;
            this.transmitButton.Text = "Wyślij";
            this.transmitButton.UseVisualStyleBackColor = true;
            this.transmitButton.Click += new System.EventHandler(this.transmitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.configureButton);
            this.panel1.Controls.Add(this.terminatorComboBox);
            this.panel1.Controls.Add(this.flowControlComboBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.portComboBox);
            this.panel1.Location = new System.Drawing.Point(9, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 206);
            this.panel1.TabIndex = 5;
            // 
            // configureButton
            // 
            this.configureButton.Location = new System.Drawing.Point(185, 176);
            this.configureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(116, 21);
            this.configureButton.TabIndex = 8;
            this.configureButton.Text = "Konfiguruj";
            this.configureButton.UseVisualStyleBackColor = true;
            this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
            // 
            // terminatorComboBox
            // 
            this.terminatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terminatorComboBox.FormattingEnabled = true;
            this.terminatorComboBox.Location = new System.Drawing.Point(102, 70);
            this.terminatorComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terminatorComboBox.Name = "terminatorComboBox";
            this.terminatorComboBox.Size = new System.Drawing.Size(168, 21);
            this.terminatorComboBox.TabIndex = 7;
            // 
            // flowControlComboBox
            // 
            this.flowControlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowControlComboBox.FormattingEnabled = true;
            this.flowControlComboBox.Location = new System.Drawing.Point(102, 46);
            this.flowControlComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowControlComboBox.Name = "flowControlComboBox";
            this.flowControlComboBox.Size = new System.Drawing.Size(168, 21);
            this.flowControlComboBox.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Terminator";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kontrola przepływu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Parametry transmisyjne:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.speedTextBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(280, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 147);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "bit/s";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(65, 11);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(56, 20);
            this.speedTextBox.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stopBitsComboBox);
            this.panel3.Controls.Add(this.controlComboBox);
            this.panel3.Controls.Add(this.dataFieldComboBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(8, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 86);
            this.panel3.TabIndex = 2;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(79, 54);
            this.stopBitsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(88, 21);
            this.stopBitsComboBox.TabIndex = 8;
            // 
            // controlComboBox
            // 
            this.controlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlComboBox.FormattingEnabled = true;
            this.controlComboBox.Location = new System.Drawing.Point(79, 31);
            this.controlComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlComboBox.Name = "controlComboBox";
            this.controlComboBox.Size = new System.Drawing.Size(88, 21);
            this.controlComboBox.TabIndex = 7;
            // 
            // dataFieldComboBox
            // 
            this.dataFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataFieldComboBox.FormattingEnabled = true;
            this.dataFieldComboBox.Location = new System.Drawing.Point(79, 6);
            this.dataFieldComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataFieldComboBox.Name = "dataFieldComboBox";
            this.dataFieldComboBox.Size = new System.Drawing.Size(88, 21);
            this.dataFieldComboBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kontrola";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Pole danych";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Bity stopu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Szybkość";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Format znaku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(102, 21);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(168, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konfiguracja:";
            // 
            // communicationPanel
            // 
            this.communicationPanel.Controls.Add(this.pingPongTextBox);
            this.communicationPanel.Controls.Add(this.pingButton);
            this.communicationPanel.Controls.Add(this.transmitButton);
            this.communicationPanel.Controls.Add(this.label2);
            this.communicationPanel.Controls.Add(this.receivedDataTextBox);
            this.communicationPanel.Controls.Add(this.label1);
            this.communicationPanel.Controls.Add(this.transmitedDataTextBox);
            this.communicationPanel.Location = new System.Drawing.Point(9, 249);
            this.communicationPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.communicationPanel.Name = "communicationPanel";
            this.communicationPanel.Size = new System.Drawing.Size(484, 214);
            this.communicationPanel.TabIndex = 7;
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(104, 186);
            this.pingButton.Margin = new System.Windows.Forms.Padding(2);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(82, 21);
            this.pingButton.TabIndex = 5;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // pingPongTextBox
            // 
            this.pingPongTextBox.Location = new System.Drawing.Point(191, 186);
            this.pingPongTextBox.Name = "pingPongTextBox";
            this.pingPongTextBox.ReadOnly = true;
            this.pingPongTextBox.Size = new System.Drawing.Size(49, 20);
            this.pingPongTextBox.TabIndex = 6;
            // 
            // IwSK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 488);
            this.Controls.Add(this.communicationPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IwSK1";
            this.Text = "IwSK1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.communicationPanel.ResumeLayout(false);
            this.communicationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox transmitedDataTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receivedDataTextBox;
        private System.Windows.Forms.Button transmitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox controlComboBox;
        private System.Windows.Forms.ComboBox dataFieldComboBox;
        private System.Windows.Forms.ComboBox terminatorComboBox;
        private System.Windows.Forms.ComboBox flowControlComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button configureButton;
        private System.Windows.Forms.Panel communicationPanel;
        private System.Windows.Forms.TextBox pingPongTextBox;
        private System.Windows.Forms.Button pingButton;
    }
}

