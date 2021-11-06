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
    public partial class AddUser : Form
    {

        public AddUser()
        {
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '*';
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(name_textBox.Text != "" && password_textBox.Text !="")
            { 
            User user = new User()
            {
                UserName = name_textBox.Text,
                Password = password_textBox.Text
            };
            Form1.programManager.AddUser(user);
            Form1.users_listBox.Items.Add(user.UserName);
                MessageBox.Show("Пользователь добавлен!");
            }
            else MessageBox.Show("Пользователь не добавлен!");
            this.Close();
            
        }
    }
}
