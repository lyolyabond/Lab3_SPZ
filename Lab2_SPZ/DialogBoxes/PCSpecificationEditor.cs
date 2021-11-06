using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_SPZ.DialogBoxes
{
    public partial class PCSpecificationEditor : Form
    {
        public PCSpecificationEditor()
        {
            InitializeComponent();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            Form1.programManager.OSType = OS_textBox.Text;
            Form1.programManager.RAM = (int)RAM_numericUpDown.Value;
            Form1.programManager.CPUFrequency = (double)CPU_numericUpDown.Value;
            Form1.programManager.HDDSpace = (double)HDD_numericUpDown.Value;
            Form1.DisplayPCSpecification();
            this.Close();

        }

        private void PCSpecificationEditor_Load(object sender, EventArgs e)
        {
            OS_textBox.Text = Form1.programManager.OSType;
            RAM_numericUpDown.Value = Form1.programManager.RAM;
            CPU_numericUpDown.Value = (decimal)Form1.programManager.CPUFrequency;
            HDD_numericUpDown.Value = (decimal)Form1.programManager.HDDSpace;
        }
    }
}
