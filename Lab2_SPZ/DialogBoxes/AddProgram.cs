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
    public partial class AddProgram : Form
    {
        public AddProgram()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if(name_textBox.Text !="" && OS_textBox.Text != "" && manufacturer_textBox.Text != "" && 
                version_numericUpDown.Value != 0 && RAM_numericUpDown.Value != 0 && CPU_numericUpDown.Value != 0
                && HDD_numericUpDown.Value != 0)
            {
                ProgramClass program = new ProgramClass()
                {
                    ProgramName = name_textBox.Text,
                    OSType = OS_textBox.Text,
                    Manufacturer = manufacturer_textBox.Text,
                    InstallationDate = dateTimePicker.Value,
                    Version = (double)version_numericUpDown.Value,
                    RAM = (int)RAM_numericUpDown.Value,
                    CPUFrequency = (double)CPU_numericUpDown.Value,
                    HDDSpace = (double)HDD_numericUpDown.Value
                };
                if (Form1.programManager.AvailabilityOfUse(program))
                { 
                    Form1.programManager.ProgramInstallation(program);
                    Form1.programs_listBox.Items.Add(program.ProgramName);
                }
                else MessageBox.Show("Программа не совместима");
            }this.Close();
        }
    }
}
