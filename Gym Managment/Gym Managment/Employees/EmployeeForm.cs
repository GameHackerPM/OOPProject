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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)

        {
            foreach(Employee employee in Program.EmployeesList)
             {
               EmployeesListBox.Items.Add(employee.FirstName+" "+employee.LastName);
            }
            
             EmpCountLb.Text = Program.EmployeesList.Count.ToString();
        }

        private void Reset()
        {
            IdTxt.Text = "";
            fNameTxt.Text = "";
            LNameTxt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            contact_NoTxt.Text = "01";
            AddressTxt.Text = "";
            DateOfJoiningDT.Value = DateTime.Now;
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

            if (usernameTxt.Text == "")
            {
                MessageBox.Show("please Enter The Username! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordTxt.Text == string.Empty)
            {
                MessageBox.Show("please Enter The Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Employee NewMember = new Employee(fNameTxt.Text, LNameTxt.Text, usernameTxt.Text, passwordTxt.Text, AddressTxt.Text, Convert.ToInt32(contact_NoTxt.Text), Convert.ToDouble(SalaryTxt.Text), DateOfJoiningDT.Value);
            Program.EmployeesList.Add(NewMember);
            EmpCountLb.Text = Program.EmployeesList.Count.ToString();
            EmployeesListBox.Items.Add(NewMember.FirstName + " " + NewMember.LastName);


        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            foreach (Employee SelectedEmployee in Program.EmployeesList)
            {
                if ((string)EmployeesListBox.SelectedItem == SelectedEmployee.FirstName + " " + SelectedEmployee.LastName)
                {
                    SelectedEmployee.FirstName = fNameTxt.Text;
                    SelectedEmployee.LastName = LNameTxt.Text;
                    SelectedEmployee.Username = usernameTxt.Text;
                    SelectedEmployee.Password = passwordTxt.Text;
                    SelectedEmployee.Contact_num = Convert.ToInt32(contact_NoTxt.Text);
                    SelectedEmployee.Address = AddressTxt.Text;
                    SelectedEmployee.DateOfJoining = DateOfJoiningDT.Value;
                    SelectedEmployee.Salary = Convert.ToDouble(SalaryTxt.Text);



                    EmployeesListBox.Items[EmployeesListBox.SelectedIndex] = SelectedEmployee.FirstName + " " + SelectedEmployee.LastName;
                    break;
                }



            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Employee SelectedEmployee in Program.EmployeesList)
            {
                if ((string)EmployeesListBox.SelectedItem == SelectedEmployee.FirstName + " " + SelectedEmployee.LastName)
                {
                    IdTxt.Text = SelectedEmployee.ID.ToString();
                    fNameTxt.Text = SelectedEmployee.FirstName;
                    LNameTxt.Text = SelectedEmployee.LastName;
                    usernameTxt.Text = SelectedEmployee.Username;
                    passwordTxt.Text = SelectedEmployee.Password;
                    contact_NoTxt.Text = "0" + SelectedEmployee.Contact_num.ToString();
                    AddressTxt.Text = SelectedEmployee.Address;
                    DateOfJoiningDT.Value = SelectedEmployee.DateOfJoining;
                    SalaryTxt.Text = SelectedEmployee.Salary.ToString();
                    break;


                }
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            foreach (Employee SelectedEmployee in Program.EmployeesList)
            {
                if ((string)EmployeesListBox.SelectedItem == SelectedEmployee.FirstName + " " + SelectedEmployee.LastName)
                {
                    Program.EmployeesList.Remove(SelectedEmployee);
                    EmpCountLb.Text = Program.EmployeesList.Count.ToString();
                    EmployeesListBox.Items.Remove(EmployeesListBox.SelectedItem);
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
