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
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var validUsername = Program.EmployeesList.FirstOrDefault(emp => emp.Username == UNtxt.Text);
            var validPassword = Program.EmployeesList.FirstOrDefault(emp => emp.Username == UNtxt.Text && emp.Password == PWtxt.Text);
            if (validUsername != null)
            {
                if (validPassword != null)
                {
                    MessageBox.Show("Logged in successfully!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.Username = UNtxt.Text;
                    new Main().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password is wrong!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Username not found!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
