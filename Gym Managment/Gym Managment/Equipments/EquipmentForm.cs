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
    public partial class EquipmentForm : Form
    {
        public int values;
        public int quntity;
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Equipment equipment in Program.EquipmentsList)
            {
                EquipmentList.Items.Add(equipment.NameOfInstrument);
            }


            equipmentCountLbl.Text = Equipment.GetCount().ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (Equipment equipment in Program.EquipmentsList)
            {
                if ((string)EquipmentList.SelectedItem == equipment.NameOfInstrument)
                {
                    Program.EquipmentsList.Remove(equipment);
                    break;
                }
                EquipmentList.Items.Remove(EquipmentList.SelectedItem);
                equipmentCountLbl.Text = Equipment.GetCount().ToString();
                ResetAll();
            }
        }

        private void ResetAll()
        {
            text_id.Text = "";
            textName.Text = "";
            textcompany.Text = "";
            text_To_Quntity.Text = "$0.00";
            txt_price_Qunt.Text = "$0.00";
            text_Total_Price.Text = "$0.00";
            dateTimePicker1.Value = DateTime.Now;


        }

        private void Reset_but_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Edit_btu_Click(object sender, EventArgs e)
        {
            //if
        }

        private void exit_but_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Add_but_Click(object sender, EventArgs e)
        {

            if (textName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Equipment's Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textcompany.Text == string.Empty)
            {
                MessageBox.Show("Please enter company's Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text_To_Quntity.Text != string.Empty)
            {
                try
                { quntity = Convert.ToInt32(text_To_Quntity.Text); }
                catch
                {
                    MessageBox.Show("Please enter  imteger number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter Equipement's quntity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (txt_price_Qunt.Text != string.Empty)
            {
                try
                {
                    values = Convert.ToInt32(txt_price_Qunt.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter  integer number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Please enter Equipement's price !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Equipment equipment = new Equipment(textName.Text, Convert.ToInt32(text_To_Quntity.Text), Convert.ToInt32(txt_price_Qunt.Text), dateTimePicker1.Value, textcompany.Text);

            Program.EquipmentsList.Add(equipment);
            equipmentCountLbl.Text = Equipment.GetCount().ToString();
            // text_Total_Price.Text = Equipment.Get_Total_price(values, quntity).ToString();

            EquipmentList.Items.Add(equipment.NameOfInstrument);
        }

        private void EquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Equipment selecteEquipement in Program.EquipmentsList)
            {
                if ((string)EquipmentList.SelectedItem == selecteEquipement.NameOfInstrument)
                {
                    text_id.Text = selecteEquipement.ID.ToString();

                    textName.Text = selecteEquipement.NameOfInstrument;
                    textcompany.Text = selecteEquipement.Company;
                    text_To_Quntity.Text = selecteEquipement.total_Quantity.ToString();
                    txt_price_Qunt.Text = selecteEquipement.price_per_Quantity.ToString();
                    dateTimePicker1.Value = selecteEquipement.Date;

                    text_Total_Price.Text = string.Format("{0:C}", selecteEquipement.total_price);
                    break;

                }
            }

        }
    }


}

