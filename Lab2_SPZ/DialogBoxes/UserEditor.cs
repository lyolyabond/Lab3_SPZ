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
    public partial class UserEditor : Form
    {
        string item = Form1.users_listBox.SelectedItem.ToString();

        public UserEditor()
        {
            InitializeComponent();
        }
        private void UserEditor_Load(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '*';
            oldpassword_textBox.PasswordChar = '*';
            name_textBox.Text = item;
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if(password_textBox.Text != "" && password_textBox.Text != Form1.programManager.UserDictionary[item].Password 
                && oldpassword_textBox.Text == Form1.programManager.UserDictionary[item].Password)
            { 
                Form1.programManager.UserDictionary[item].Password = password_textBox.Text;
                MessageBox.Show("Пароль изменён");
                this.Close();
            }
            else if(oldpassword_textBox.Text != Form1.programManager.UserDictionary[item].Password)
            {
                MessageBox.Show("Старый пароль введён неправильно");
                oldpassword_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Пароль не изменён");
                this.Close();
            }
        }
 
    }
}
