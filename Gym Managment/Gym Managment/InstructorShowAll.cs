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
    public partial class InstructorShowAll : Form
    {
        public InstructorShowAll()
        {
            InitializeComponent();
        }

        private void InstructorShowAll_Load(object sender, EventArgs e)
        {
            modeCombo.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Contact Number");
            dt.Columns.Add("Address");
            dt.Columns.Add("DateOfJoining");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Schedule");

            foreach (Instructor instructor in Program.InstructorsList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = instructor.ID.ToString();
                row["Name"] = instructor.FirstName + " " + instructor.LastName;
                row["Contact Number"] = "0" + instructor.ContactNo.ToString();
                row["Address"] = instructor.Address;
                row["DateOfJoining"] = instructor.DateOfJoining.ToString("dd/MM/yyy");
                row["Salary"] = string.Format("{0:C}", instructor.Salary);
                string schedule = "";
                switch (instructor.Schedule)
                {
                    case (int)Instructor.ScheduleTypes.Evening:
                        schedule = "Evening";
                        break;
                    case (int)Instructor.ScheduleTypes.FullDay:
                        schedule = "Full Day";
                        break;
                    case (int)Instructor.ScheduleTypes.Morning:
                        schedule="Morning";
                        break;
                }
                row["Schedule"] = schedule;
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
                    SelectedColumn = "DateOfJoining";
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
