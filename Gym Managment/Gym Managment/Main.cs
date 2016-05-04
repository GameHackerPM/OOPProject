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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutStrip_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
        }

        private void contactStrip_Click(object sender, EventArgs e)
        {

        }

        private void quitStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void minimizeToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            new MembersForm().Show();
        }

        private void instructorBtn_Click(object sender, EventArgs e)
        {
            new InstructorForm().Show();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            new TransactionsForm().Show();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new TransactionsForm().Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MembersShowAll().Show();
        }

        private void showAllToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new TransactionsShowAll().Show();
        }
    }
}
