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
            new TransactionsShowAll().Show(); //ShowAll
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MembersForm().Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new InstructorForm().Show();
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
        }

        private void showAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new InstructorShowAll().Show();
        }

        private void showAllToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new EmployeeShowAll().Show();
        }

        private void equipmentsBtn_Click(object sender, EventArgs e)
        {
            new EquipmentForm().Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = Program.Username;
        }

        private void showAllToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Gym_Managment.Equipments.EquipmentShowAll().Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new EquipmentForm().Show();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            new SuppliersForm().Show();
        }

        private void showAllToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new SuppliersShowAll().Show();
        }

        private void planBtn_Click(object sender, EventArgs e)
        {
            new Plan_CoursesForm().Show();   
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Plan_CoursesForm().Show();
        }

        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new SuppliersForm().Show();
        }

        
    }
}
