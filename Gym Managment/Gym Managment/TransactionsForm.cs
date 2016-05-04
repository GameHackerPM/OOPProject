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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            foreach (Plan_Courses plan in Program.Plan_CoursesList)
            {
                plantypeCombo.Items.Add(plan.planname);
            }
            dateTimePicker1.Value = DateTime.Now;
            plantypeCombo.SelectedIndex = 0;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (idTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter Member ID who will pay the bill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double amount = 0;
            foreach (Plan_Courses plan in Program.Plan_CoursesList)
            {
                if ((string)plantypeCombo.SelectedItem == plan.planname)
                {
                    amount = plan.amount;
                    break;
                }

            }
            var SelectedMemeber = Program.MembersList.FirstOrDefault(p=> p.ID == Convert.ToInt32(idTxt.Text));
            if (SelectedMemeber == null)
            {
                MessageBox.Show("Couldn't find this member ID in database, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Transactions NewTransaction = new Transactions(SelectedMemeber, amount, dateTimePicker1.Value);

            SelectedMemeber.Transaction.Amount += amount;

            Program.TransactionsList.Add(NewTransaction);
            MessageBox.Show("Bill has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void plantypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Plan_Courses plan in Program.Plan_CoursesList)
            {
                if ((string)plantypeCombo.SelectedItem == plan.planname)
                {
                    amountTxt.Text = string.Format("{0:C}", plan.amount);
                    break;
                }
            }
        }
    }
}
