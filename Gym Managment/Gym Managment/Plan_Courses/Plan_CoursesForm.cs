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
    public partial class Plan_CoursesForm : Form
    {
        public Plan_CoursesForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (plannameTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter plans's Plan Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amountTxt.Text != string.Empty)
            {
                try
                {
                    double amount = Convert.ToDouble(amountTxt.Text); 
                }
                catch
                {
                    MessageBox.Show("Please enter amount of plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter amount of plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (detailsTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter plans'details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Plan_Courses NewPlan = new Plan_Courses(plannameTxt.Text, Convert.ToInt32(idTxt.Text), Convert.ToDouble(amountTxt.Text), detailsTxt.Text);

            Program.Plan_CoursesList.Add(NewPlan);

            plan_coursesList.Items.Add(NewPlan.planname);
        }

        private void Plan_CoursesForm_Load(object sender, EventArgs e)
        {
            foreach (Plan_Courses plan in Program.Plan_CoursesList)
                
            {
                plan_coursesList.Items.Add(plan.planname);
            
            }

            
        }


        private void ResetAll()
        {
            idTxt.Text = "";
            plannameTxt.Text = "";
            detailsTxt.Text = "";
            amountTxt.Text = "$0.00";

        }
        
        
        private void resetbutton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {

            foreach (Plan_Courses selectedPlan in Program.Plan_CoursesList)
            {
                if ((string)plan_coursesList.SelectedItem == selectedPlan.planname)
                {
                    selectedPlan.planname = plannameTxt.Text;
                    selectedPlan.amount = Convert.ToDouble(amountTxt.Text);
                    selectedPlan.details = detailsTxt.Text;




                    plan_coursesList.Items[plan_coursesList.SelectedIndex] = selectedPlan.planname;
                    break;

                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            foreach (Plan_Courses plan in Program.Plan_CoursesList)
            {
                if ((string)plan_coursesList.SelectedItem == plan.planname)
                {
                    Program.Plan_CoursesList.Remove(plan);
                    break;

                }

                plan_coursesList.Items.Remove(plan_coursesList.SelectedItem);

                ResetAll();
            } 
            
           
       }

        private void plan_coursesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Plan_Courses selectedPlan in Program.Plan_CoursesList)
            {
                if ((string)plan_coursesList.SelectedItem == selectedPlan.planname)
                {
                    idTxt.Text = selectedPlan.ID.ToString();
                    plannameTxt.Text = selectedPlan.planname;
                    amountTxt.Text =  selectedPlan.amount.ToString();
                    detailsTxt.Text = selectedPlan.details;
                    
                    break;
                }
            }
        }
    }
 }
