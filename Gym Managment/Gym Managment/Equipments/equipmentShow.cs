using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_Managment.Equipments
{
    public partial class EquipmentShowAll : Form
    {
        public EquipmentShowAll()
        {
            InitializeComponent();
        }

        private void equipmentShow_Load(object sender, EventArgs e)
        {modeCombo.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Company");
            dt.Columns.Add("Quntity");
            dt.Columns.Add("Price per Quntity");
            dt.Columns.Add("Total Price");
            dt.Columns.Add("Date");

            foreach (Equipment euipment in Program.EquipmentsList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = euipment.ID.ToString();
                row["Name"] = euipment.NameOfInstrument;
                row["Copmany"] =  euipment.Company;
                row["Quntity"] = euipment.total_Quantity.ToString();
                row["Price per Quntity"] =euipment.price_per_Quantity.ToString();
                row["Total Price"] = string.Format("{0:C}", euipment.total_price);
                row["Date"] = euipment.Date.ToString("dd/MM/yyy");
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
                    SelectedColumn = "Date";
                    break;
                case 3:
                    SelectedColumn = "Company";
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

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
