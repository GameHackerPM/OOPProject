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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            foreach (Instructor instructor in Program.InstructorsList)
            {
                InstructorListBox.Items.Add(instructor.FirstName + " " + instructor.LastName);

            }
            InCountLb.Text = Program.InstructorsList.Count.ToString();
        }

        private void Reset()
        {
            IdTxt.Text = "";
            fNameTxt.Text = "";
            LNameTxt.Text = "";
            contact_NoTxt.Text = "01";
            AddressTxt.Text = "";
            DateOfJoiningDT.Value = DateTime.Now;
            Schdule_Combo.Text = "Morning";
            SalaryTxt.Text = "$00.00";

        }


        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (fNameTxt.Text == "")
            {
                MessageBox.Show("please Enter The First Name ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LNameTxt.Text == string.Empty)
            {
                MessageBox.Show("please Enter The Last Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contact_NoTxt.Text != "")
            {
                try
                {
                    int contact;
                    contact = Convert.ToInt32(contact_NoTxt.Text);
                }
                catch
                {
                    MessageBox.Show("please enter the contact number is number ,not anthor", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
            else
            {
                MessageBox.Show("please Enter The Contact Number ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AddressTxt.Text == "")
            {
                MessageBox.Show("please Enter The Address ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Instructor newcommer = new Instructor(fNameTxt.Text, LNameTxt.Text, AddressTxt.Text, Convert.ToInt32(contact_NoTxt.Text), Convert.ToDouble(SalaryTxt.Text), DateOfJoiningDT.Value, Schdule_Combo.SelectedIndex);
            Program.InstructorsList.Add(newcommer);
            InCountLb.Text = Program.InstructorsList.Count.ToString();
            InstructorListBox.Items.Add(newcommer.FirstName + " " + newcommer.LastName);


        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            foreach (Instructor selectedInstructor in Program.InstructorsList)
            {
                if ((string)InstructorListBox.SelectedItem == selectedInstructor.FirstName + " " + selectedInstructor.LastName)
                {
                    selectedInstructor.FirstName = fNameTxt.Text;
                    selectedInstructor.LastName = LNameTxt.Text;
                    selectedInstructor.ContactNo =Convert.ToInt32(contact_NoTxt.Text);
                    selectedInstructor.Address = AddressTxt.Text;
                    selectedInstructor.DateOfJoining = DateOfJoiningDT.Value;
                    selectedInstructor.Schedule = Schdule_Combo.SelectedIndex;
                    selectedInstructor.Salary = Convert.ToDouble(SalaryTxt.Text);


                    InstructorListBox.Items[InstructorListBox.SelectedIndex] = selectedInstructor.FirstName + " " + selectedInstructor.LastName ;
                    break;

                }
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstructorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Instructor selectedInstructor in Program.InstructorsList)
            {
                if ((string)InstructorListBox.SelectedItem == selectedInstructor.FirstName + " " + selectedInstructor.LastName)
                {
                    IdTxt.Text = selectedInstructor.ID.ToString();
                    fNameTxt.Text = selectedInstructor.FirstName;
                    LNameTxt.Text = selectedInstructor.LastName;
                    contact_NoTxt.Text = "0" + selectedInstructor.ContactNo.ToString();
                    AddressTxt.Text = selectedInstructor.Address;
                    DateOfJoiningDT.Value = selectedInstructor.DateOfJoining;
                    Schdule_Combo.SelectedIndex = selectedInstructor.Schedule;
                    SalaryTxt.Text = selectedInstructor.Salary.ToString();
                    break;

                }
            }
        }


       

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

            foreach (Instructor selectedInstructor in  Program.InstructorsList)
            {
                if ((string)InstructorListBox.SelectedItem == selectedInstructor.FirstName + " " + selectedInstructor.LastName)
                {
                    Program.InstructorsList.Remove(selectedInstructor);
                    InCountLb.Text = Program.InstructorsList.Count.ToString();
                    InstructorListBox.Items.Remove(InstructorListBox.SelectedItem);
                    break;
                }

            }

        }

        private void fNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             
                LNameTxt.Focus();
               e.Handled = true;

            }
        }

        private void LNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                contact_NoTxt.Focus();
                e.Handled = true;
            }
        }

        private void contact_NoTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                AddressTxt.Focus();
                e.Handled = true;
            }
        }

    }
}

