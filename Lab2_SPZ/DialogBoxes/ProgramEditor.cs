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
    public partial class ProgramEditor : Form
    {
        ProgramClass program;
        int index;
        public ProgramEditor()
        {
            InitializeComponent();
        }

        private void ProgramEditor_Load(object sender, EventArgs e)
        {
            index = Form1.programs_listBox.SelectedIndex;
            var prog = Form1.programManager.ListOfInstalledPrograms[index];
            
                    programName_textBox.Text = prog.ProgramName;
                    OS_textBox.Text = prog.OSType;
                    manufacturer_textBox.Text = prog.Manufacturer;
                    dateTimePicker.Value = prog.InstallationDate;
                    version_numericUpDown.Value = (decimal)prog.Version;
                    RAM_numericUpDown.Value = (decimal)prog.RAM;
                    CPU_numericUpDown.Value = (decimal)prog.CPUFrequency;
                    HDD_numericUpDown.Value = (decimal)prog.HDDSpace;
                    program = prog;            
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            Form1.programManager.ListOfInstalledPrograms[index].OSType = OS_textBox.Text;
            Form1.programManager.ListOfInstalledPrograms[index].Manufacturer = manufacturer_textBox.Text;
            Form1.programManager.ListOfInstalledPrograms[index].InstallationDate = dateTimePicker.Value;
            Form1.programManager.ListOfInstalledPrograms[index].Version = (double)version_numericUpDown.Value;
            Form1.programManager.ListOfInstalledPrograms[index].RAM = (int)RAM_numericUpDown.Value;
            Form1.programManager.ListOfInstalledPrograms[index].CPUFrequency = (double)CPU_numericUpDown.Value;
            Form1.programManager.ListOfInstalledPrograms[index].HDDSpace = (double)HDD_numericUpDown.Value;   
            this.Close();
        }
    }
}
