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
    public partial class TransactionsShowAll : Form
    {
        public TransactionsShowAll()
        {
            InitializeComponent();
        }

        private void TransactionsShowAll_Load(object sender, EventArgs e)
        {
            modeCombo.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("TransactionID");
            dt.Columns.Add("MemberID");
            dt.Columns.Add("MemberName");
            dt.Columns.Add("PayingDate");
            dt.Columns.Add("Amount");

            foreach (Transactions transaction in Program.TransactionsList)
            {
                DataRow row = dt.NewRow();
                row["TransactionID"] = transaction.ID.ToString();
                row["MemberID"] = transaction.MemberID.ToString();
                row["MemberName"] = transaction.MemberName;
                row["PayingDate"] = transaction.DateOfPay.ToString("dd/MM/yyyy");
                row["Amount"] = string.Format("{0:C}", transaction.Amount);
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
                    SelectedColumn = "MemberID";
                    break;
                case 1:
                    SelectedColumn = "MemberName";
                    break;
                case 2:
                    SelectedColumn = "PayingDate";
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
