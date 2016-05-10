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
    public partial class MembersShowAll : Form
    {
        public MembersShowAll()
        {
            InitializeComponent();
        }

        private void MembersShowAll_Load(object sender, EventArgs e)
        {
            modeCombo.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Contact Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("Plan Type");
            dt.Columns.Add("JoiningDate");
            dt.Columns.Add("Amount");

            foreach (Members member in Program.MembersList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = member.ID.ToString();
                row["Name"] = member.FirstName + " " + member.LastName;
                row["Contact Number"] = "0" + member.Contact_No.ToString();
                row["Address"] = member.Address;
                row["Plan Type"] = member.PlanType.ToString();
                row["JoiningDate"] = member.DateOfJoining.ToString("dd/MM/yyy");
                row["Amount"] = string.Format("{0:C}", member.Amount);
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
            bool colored = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (colored)
                    row.DefaultCellStyle.BackColor = Color.Silver;
                colored = !colored;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string SelectedColumn = "";
            switch (modeCombo.SelectedIndex)
            {
                case 0:
                    SelectedColumn = "ID";
                    break;
                case 1:
                    SelectedColumn = "Name";
                    break;
                case 2:
                    SelectedColumn = "JoiningDate";
                    break;
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = SelectedColumn + " LIKE '%" + searchTxt.Text + "%'";
            dataGridView1.DataSource = bs;

            bool colored = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (colored)
                    row.DefaultCellStyle.BackColor = Color.Silver;
                colored = !colored;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTxt.Text = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "ID LIKE '%%'";
            dataGridView1.DataSource = bs;
            bool colored = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (colored)
                    row.DefaultCellStyle.BackColor = Color.Silver;
                colored = !colored;
            }
        }

       
    }
}
