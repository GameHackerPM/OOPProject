using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_Managment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool ValidUsername = true;
            bool ValidPassword = true;
            //foreach (Employee emp in Program.EmpList)
            //{
            //    if (emp.Username == UNtxt.Text && emp.Password == PWtxt.Text)
            //    {
            //        ValidUsername = true;
            //        ValidPassword = true;
            //    }
            //    if (emp.Username == UNtxt.Text)
            //        ValidUsername = true;
            //}
            if (ValidUsername == true)//true?
            {
                if (ValidPassword == true)
                {
                    MessageBox.Show("Logged in successfully!");
                }
                else
                    MessageBox.Show("Password is wrong!");
            }
            else
                MessageBox.Show("Username not found!");
        }
    }
}
