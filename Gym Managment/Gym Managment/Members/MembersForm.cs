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
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            foreach (Members member in Program.MembersList)
            {
                membersList.Items.Add(member.FirstName + " " + member.LastName);
            }
            foreach (Plan_Courses plan in Program.Plan_CoursesList)
            {
                plantypeCombo.Items.Add(plan.planname);
            }
            plantypeCombo.SelectedIndex = 0;
            membersCountLbl.Text = Members.GetCount().ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (Members member in Program.MembersList)
            {
                if ((string)membersList.SelectedItem == member.FirstName + " " + member.LastName)
                {
                    Program.MembersList.Remove(member);
                    break;
                }
            }
            membersList.Items.Remove(membersList.SelectedItem);
            membersCountLbl.Text = Members.GetCount().ToString();
            ResetAll();
        }

        private void ResetAll()
        {
            idTxt.Text = "";
            firstnameTxt.Text = "";
            lastnameTxt.Text = "";
            contactnoTxt.Text = "01";
            addressTxt.Text = "";
            dateofjoiningDate.Value = DateTime.Now;
            plantypeCombo.Text = "";
            amountTxt.Text = "$0.00";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void membersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Members selectedMember in Program.MembersList)
            {
                if ((string)membersList.SelectedItem == selectedMember.FirstName + " " + selectedMember.LastName)
                {
                    idTxt.Text = selectedMember.ID.ToString();
                    firstnameTxt.Text = selectedMember.FirstName;
                    lastnameTxt.Text = selectedMember.LastName;
                    contactnoTxt.Text = "0" + selectedMember.Contact_No.ToString();
                    addressTxt.Text = selectedMember.Address;
                    dateofjoiningDate.Value = selectedMember.DateOfJoining;
                    plantypeCombo.SelectedIndex = selectedMember.PlanType - 1;
                    amountTxt.Text = string.Format("{0:C}", selectedMember.Amount);
                    break;
                }
            }
        }
        
        private void amountTxt_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    double value = amountTxt.Text == string.Empty ? 0 : Convert.ToInt32(amountTxt.Text.Replace("$", "").Replace(",",""));
            //    amountTxt.Text = string.Format("{0:C}", value);

            //}
            //catch
            //{
            //    amountTxt.Text = string.Format("{0:C}", 0);
            //}

            if (!amountTxt.Text.Contains("$"))
                amountTxt.Text = "$" + amountTxt.Text;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //double amo = double.Parse(amountTxt.Text.Replace("$", "").Replace(".", "").Remove(amountTxt.Text.IndexOf(amountTxt.Text.Length - 2))));
            //MessageBox.Show(amo.ToString());
            if (firstnameTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter member's First Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lastnameTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter member's Last Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contactnoTxt.Text != string.Empty)
            {
                try
                {
                    int value = Convert.ToInt32(contactnoTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter member's valid Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter member's Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addressTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter member's Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Members NewMember = new Members(firstnameTxt.Text, lastnameTxt.Text, Convert.ToInt32(contactnoTxt.Text), addressTxt.Text, plantypeCombo.SelectedIndex + 1, 1, dateofjoiningDate.Value);

            Program.MembersList.Add(NewMember);
            membersCountLbl.Text = Members.GetCount().ToString();
            membersList.Items.Add(NewMember.FirstName + " " + NewMember.LastName);
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
