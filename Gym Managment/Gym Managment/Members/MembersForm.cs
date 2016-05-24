using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

            //Save to Database
            for (int i = 0; i < Program.AllMembers.Count; i++)
            {
                string member = Program.AllMembers[i].Trim();
                string[] data = member.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                if ((string)membersList.SelectedItem == data[0] + " " + data[1])
                {
                    Program.AllMembers[i] = firstnameTxt.Text + "~" + lastnameTxt.Text + "~" + contactnoTxt.Text + "~" + addressTxt.Text + "~" + (plantypeCombo.SelectedIndex + 1) + "~" + double.Parse(amountTxt.Text.Replace("$", ""), CultureInfo.InvariantCulture) + "~" + Program.ToDateTimeInt(dateofjoiningDate.Value);
                    File.WriteAllLines("Database//Members.txt", Program.AllMembers.ToArray());
                }
            }
            for (int i = 0; i < Program.AllTransactions.Count; i++)
            {
                string transaction = Program.AllTransactions[i].Trim();
                string[] data = transaction.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                if ((string)membersList.SelectedItem == data[0])
                {
                    Program.AllTransactions[i] = firstnameTxt.Text + " " + lastnameTxt.Text + "~" + data[1] + "~" + data[2];
                    File.WriteAllLines("Database//Transactions.txt", Program.AllTransactions.ToArray());
                }
            }
            /////////////////////////////

            foreach (Members selectedMember in Program.MembersList)
            {
                if ((string)membersList.SelectedItem == selectedMember.FirstName + " " + selectedMember.LastName)
                {
                    selectedMember.FirstName = firstnameTxt.Text;
                    selectedMember.LastName = lastnameTxt.Text;
                    selectedMember.Contact_No = Convert.ToInt32(contactnoTxt.Text);
                    selectedMember.Address = addressTxt.Text;
                    selectedMember.DateOfJoining = dateofjoiningDate.Value;
                    selectedMember.PlanType = plantypeCombo.SelectedIndex + 1;
                    selectedMember.Amount = double.Parse(amountTxt.Text.Replace("$",""), CultureInfo.InvariantCulture);

                    membersList.Items[membersList.SelectedIndex] = selectedMember.FirstName + " " + selectedMember.LastName;
                    break;

                }
            }
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
            amountTxt.Text = string.Format("{0:C}", double.Parse(amountTxt.Text.Replace("$", ""), CultureInfo.InvariantCulture));
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

            Members NewMember = new Members(firstnameTxt.Text, lastnameTxt.Text, Convert.ToInt32(contactnoTxt.Text), addressTxt.Text, plantypeCombo.SelectedIndex + 1, double.Parse(amountTxt.Text.Replace("$", ""), CultureInfo.InvariantCulture), dateofjoiningDate.Value);
            Program.MembersList.Add(NewMember);
            membersCountLbl.Text = Members.GetCount().ToString();
            membersList.Items.Add(NewMember.FirstName + " " + NewMember.LastName);

            //Save to Database
            Program.AllMembers.Add(firstnameTxt.Text + "~" + lastnameTxt.Text + "~" + contactnoTxt.Text + "~" + addressTxt.Text + "~" + (plantypeCombo.SelectedIndex + 1) + "~" + double.Parse(amountTxt.Text.Replace("$", ""), CultureInfo.InvariantCulture) + "~" + Program.ToDateTimeInt(dateofjoiningDate.Value));
            File.WriteAllLines("Database//Members.txt", Program.AllMembers.ToArray());
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
