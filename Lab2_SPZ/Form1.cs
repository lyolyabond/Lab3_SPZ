using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_SPZ
{
    public partial class Form1 : Form
    {
        public static ProgramManager programManager;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programManager = new ProgramManager()
            {
                OSType = "Windows 10",
                CPUFrequency = 3.6,
                RAM = 8,
                HDDSpace = 203.6
            };
            DisplayPCSpecification();

            DateTime dateTime = new DateTime(2020, 2, 23);
            ProgramClass program = new ProgramClass("Visual Studio", "Windows 10", "Microsoft", dateTime,
                16.22, 2, 1.8, 20);
            programManager.ProgramInstallation(program);

            dateTime = new DateTime(2019, 12, 30);
            program = new ProgramClass("The Sims 4", "Windows 10", "The Sims Studio", dateTime,
                4, 4, 1.8, 28);
            programManager.ProgramInstallation(program);

            dateTime = new DateTime(2019, 9, 12);
            program = new ProgramClass("RAID: Shadow Legends", "Windows 10", "Plarium", dateTime,
                4.71, 2, 1.8, 5);
            programManager.ProgramInstallation(program);

            User user = new User()
            {
                UserName = "Lyolya",
                Password = "12345"
            };
            programManager.AddUser(user);
            user = new User()
            {
                UserName = "SuperStar",
                Password = "qwerty"
            };
            programManager.AddUser(user);

            DisplayList();
            DisplayDictionary();
            programs_listBox.SelectionMode = SelectionMode.MultiExtended;
            users_listBox.SelectionMode = SelectionMode.MultiExtended;

        }
        public static void DisplayPCSpecification()
        {
            toolStripStatusLabel.Text = $"Частота процессора: {programManager.CPUFrequency} ГГц," +
                $"Оперативная память: {programManager.RAM} Гб, Жёсткий диск: {programManager.HDDSpace} Гб," +
                $"ОС: {programManager.OSType}";
        }
        public static void DisplayList()
        {
            foreach (var prog in programManager.ListOfInstalledPrograms)
            {
                programs_listBox.Items.Add(prog.ProgramName);
            }
        }
        public static void DisplayDictionary()
        {
            foreach (var oneUser in programManager.UserDictionary)
            {
                users_listBox.Items.Add(oneUser.Key);
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            DialogBoxes.AddUser formAdd = new DialogBoxes.AddUser();
            formAdd.ShowDialog();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string name;
            if(users_listBox.SelectedItem != null)
            {
                name = users_listBox.SelectedItem.ToString();
                programManager.DeleteUser(name);
                MessageBox.Show($"Пользователь {name} удалён");
                users_listBox.Items.Clear();
                DisplayDictionary();
            }
        }
        private void uninstallation_button_Click(object sender, EventArgs e)
        {
            int index;
            if ((index = programs_listBox.SelectedIndex) != -1)
            {
                programManager.ProgramDelete(programManager.ListOfInstalledPrograms[index]);
                MessageBox.Show("Прoграмма удалена");
                programs_listBox.Items.Clear();
                DisplayList();
            }
        }
        private void installation_button_Click(object sender, EventArgs e)
        {
            DialogBoxes.AddProgram addProgram = new DialogBoxes.AddProgram();
            addProgram.ShowDialog();
        }

        private void programs_listBox_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            
            if(list.SelectedItem != null)
            {
                DialogBoxes.ProgramEditor programEditor = new DialogBoxes.ProgramEditor();
                programEditor.ShowDialog();

            }
        }
        private void users_listBox_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;

            if (list.SelectedItem != null)
            {
                DialogBoxes.UserEditor userEditor = new DialogBoxes.UserEditor();
                userEditor.ShowDialog();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int index;
            if((index = programs_listBox.SelectedIndex) != -1)
            { 
            Random random = new Random();
            
            var program = programManager.ListOfInstalledPrograms[index];
            programManager.ChangeVersion(program, program.Version + random.NextDouble());
            program.RAM = random.Next(program.RAM, program.RAM + 3);
            program.CPUFrequency += random.NextDouble();
            }
        }

        private void toolStripStatusLabel_DoubleClick(object sender, EventArgs e)
        {
            DialogBoxes.PCSpecificationEditor specificationEditor = new DialogBoxes.PCSpecificationEditor();
            specificationEditor.ShowDialog();
        }
        private void compare_button_Click(object sender, EventArgs e)
        {
            CompareUsers();
            ComparePrograms();
        }
        private void CompareUsers()
        {
            string[] names = new string[2];

            int index = 0;
            for (int i = 0; i < programManager.NumberOfUsers; i++)
            {
                if (users_listBox.GetSelected(i))
                {
                    names[index] = users_listBox.Items[i].ToString();
                    if (index < 1)
                        index++;
                    else break;
                }
            }
            if (names[0] != null && names[1] != null)
            {
                if (!programManager.CompareUsers(names[0], names[1]))
                    MessageBox.Show($"Количество установленных програм пользователей {names[0]} и {names[1]} не равны.");
                else MessageBox.Show("Количество установленных програм равны.");
            }
        }
        private void ComparePrograms()
        {
            int[] indexes = new int[2] { -1, -1 };
            int index = 0;
            for (int i = 0; i < programManager.NumberOfInstalledPrograms; i++)
            {
                if (programs_listBox.GetSelected(i))
                {
                    indexes[index] = i;
                    if (index < 1)
                        index++;
                    else break;
                }
            }
            if (indexes[0] != -1 && indexes[1] != -1)
            {
                if (!programManager.ComparePrograms(indexes[0], indexes[1]))
                    MessageBox.Show($"Программы {indexes[0]} и {indexes[1]} совместимы.");
                else MessageBox.Show($"Программы {indexes[0]} и {indexes[1]} не совместимы.");
            }
        }
        private void SelectedItems(out string name, out int index)
        {
             name = default;
            if ((index = programs_listBox.SelectedIndex) != -1 && users_listBox.SelectedItem.ToString() != null)
            {
                name = users_listBox.SelectedItem.ToString();    
            }
        }
        private void larger_button_Click(object sender, EventArgs e)
        {
            string name;
            int index;
            SelectedItems(out name, out index);
            if (name != null && index != -1)
            {
                if(programManager.UserDictionary[name].AddToAvailablePrograms(programManager.ListOfInstalledPrograms[index]))
                MessageBox.Show($"Програма установлена пользователю \"{name}\"");
            }
        }
        private void smaller_button_Click(object sender, EventArgs e)
        {
            string name;
            int index;
            SelectedItems(out name, out index);
            if (name != null && index != -1)
            {
               if( programManager.UserDictionary[name].DeleteProgram(programManager.ListOfInstalledPrograms[index]))
                MessageBox.Show($"Програма удалена у пользователя \"{name}\"");
            }
        }
    }
}
