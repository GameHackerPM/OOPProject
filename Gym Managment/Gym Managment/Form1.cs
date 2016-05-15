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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  foreach (Supplier supplier in Program.SupplierList)
            {
                SuppliersList.Items.Add(supplier.Name);
            }
            supplierCountLbl.Text = Supplier.GetCount().ToString();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            foreach (Supplier supplier in Program.SupplierList)
            {
                if ((string)SuppliersList.SelectedItem == supplier.Name)
                {
                    Program.SupplierList.Remove(supplier);
                    break;
                }
            }
            SuppliersList.Items.Remove(SuppliersList.SelectedItem);
            supplierCountLbl.Text = Supplier.GetCount().ToString();
            ResetAll();
        }
          private void ResetAll()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textbox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "01";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
             ResetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
               if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter supplier Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please enter campany  Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox6.Text != string.Empty)
            {
                try
                {
                    int value = Convert.ToInt32(textBox6.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter supplier's valid Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter supplier's Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textbox3.Text == string.Empty)
            {
                MessageBox.Show("Please enter supplier's Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text != string.Empty)
            {
                try
                {
                    int value = Convert.ToInt32(textBox6.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter equipment's integer Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter supplier's Equipment !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Supplier Newsupplier = new Supplier(textBox2.Text, Convert.ToInt32(textBox6.Text), textBox4.Text, textbox3.Text, Convert.ToInt32(textBox5));

            Program.SupplierList.Add(Newsupplier);
            supplierCountLbl.Text = Supplier.GetCount().ToString();
            SuppliersList.Items.Add(Newsupplier.Name);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
         this.Close();
        }

        private void SuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
        foreach (Supplier selectedsupplier in Program.SupplierList)
            {
                if ((string)SuppliersList.SelectedItem == selectedsupplier.Name)
                {
                    textBox1.Text = selectedsupplier.ID.ToString();
                    textBox2.Text = selectedsupplier.Name;
                    textBox4.Text = selectedsupplier.Company;
                    textBox6.Text = "0" + selectedsupplier.Contact_No.ToString();
                    textbox3.Text = selectedsupplier.Address;
                    textBox5.Text = selectedsupplier.Equipment.ToString();


                    break;
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            foreach (Supplier selectedsupplier in Program.SupplierList)
            {
                if ((string)SuppliersList.SelectedItem == selectedsupplier.Name)
                {
                    selectedsupplier.Name = textBox2.Text;
                    selectedsupplier.Company = textBox4.Text;
                    selectedsupplier.Contact_No = Convert.ToInt32(textBox6.Text);
                    selectedsupplier.Address = textbox3.Text;
                    selectedsupplier.Equipment = Convert.ToInt32(textBox5.Text);




                   SuppliersList.Items[SuppliersList.SelectedIndex] = selectedsupplier.Name;
                    break;

                }
            }
        }


        
        }
    }




          