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
            if (UNtxt.Text == Program.Username)//Edit
            {
                if (PWtxt.Text == Program.Password)
                {
                    //MessageBox.Show("Logged in successfully!");
                    new Main().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password is wrong!");
            }
            else
                MessageBox.Show("Username not found!");
        }
    }
}
