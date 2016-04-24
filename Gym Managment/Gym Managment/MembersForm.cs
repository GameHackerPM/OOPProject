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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void amountTxt_TextChanged(object sender, EventArgs e)
        {
            //amountTxt.Text = string.Format("{0:C}", Convert.ToInt32(amountTxt.Text)); 
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
                    contactnoTxt.Text = selectedMember.Contact_No.ToString();
                    addressTxt.Text = selectedMember.Address;
                    dateofjoiningDate.Value = selectedMember.DateOfJoining;
                    plantypeCombo.SelectedIndex = selectedMember.PlanType - 1;
                    amountTxt.Text = string.Format("{0:C}", selectedMember.Amount);
                }
            }
        }
    }
}
