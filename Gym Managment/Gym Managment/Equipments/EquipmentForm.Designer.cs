﻿namespace Gym_Managment
{
    partial class EquipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.equipmentCountLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_price_Qunt = new System.Windows.Forms.TextBox();
            this.text_Total_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_To_Quntity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcompany = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.Edit_btu = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.Reset_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 94;
            this.label9.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 352);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.EquipmentList);
            this.groupBox1.Controls.Add(this.equipmentCountLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 526);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment  Information";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(57, 482);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(127, 32);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Selected";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EquipmentList
            // 
            this.EquipmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentList.FormattingEnabled = true;
            this.EquipmentList.ItemHeight = 16;
            this.EquipmentList.Location = new System.Drawing.Point(5, 89);
            this.EquipmentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EquipmentList.Name = "EquipmentList";
            this.EquipmentList.Size = new System.Drawing.Size(233, 388);
            this.EquipmentList.TabIndex = 0;
            this.EquipmentList.SelectedIndexChanged += new System.EventHandler(this.EquipmentList_SelectedIndexChanged);
            // 
            // equipmentCountLbl
            // 
            this.equipmentCountLbl.AutoSize = true;
            this.equipmentCountLbl.Location = new System.Drawing.Point(165, 30);
            this.equipmentCountLbl.Name = "equipmentCountLbl";
            this.equipmentCountLbl.Size = new System.Drawing.Size(16, 17);
            this.equipmentCountLbl.TabIndex = 3;
            this.equipmentCountLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Equipment List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Equipment Count : ";
            // 
            // txt_price_Qunt
            // 
            this.txt_price_Qunt.Location = new System.Drawing.Point(479, 214);
            this.txt_price_Qunt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_price_Qunt.Name = "txt_price_Qunt";
            this.txt_price_Qunt.Size = new System.Drawing.Size(184, 22);
            this.txt_price_Qunt.TabIndex = 91;
            // 
            // text_Total_Price
            // 
            this.text_Total_Price.Location = new System.Drawing.Point(479, 261);
            this.text_Total_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Total_Price.Name = "text_Total_Price";
            this.text_Total_Price.ReadOnly = true;
            this.text_Total_Price.Size = new System.Drawing.Size(184, 22);
            this.text_Total_Price.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "Price Per Quntity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Total Price :";
            // 
            // text_To_Quntity
            // 
            this.text_To_Quntity.Location = new System.Drawing.Point(479, 167);
            this.text_To_Quntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_To_Quntity.Name = "text_To_Quntity";
            this.text_To_Quntity.Size = new System.Drawing.Size(184, 22);
            this.text_To_Quntity.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Total Quntity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Company :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Name of instrument :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID :";
            // 
            // textcompany
            // 
            this.textcompany.Location = new System.Drawing.Point(479, 124);
            this.textcompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textcompany.Name = "textcompany";
            this.textcompany.Size = new System.Drawing.Size(184, 22);
            this.textcompany.TabIndex = 82;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(479, 76);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(184, 22);
            this.textName.TabIndex = 81;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(479, 31);
            this.text_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(184, 22);
            this.text_id.TabIndex = 80;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(352, 438);
            this.Add_but.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(116, 42);
            this.Add_but.TabIndex = 79;
            this.Add_but.Text = "Add";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // Edit_btu
            // 
            this.Edit_btu.Location = new System.Drawing.Point(479, 438);
            this.Edit_btu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit_btu.Name = "Edit_btu";
            this.Edit_btu.Size = new System.Drawing.Size(116, 42);
            this.Edit_btu.TabIndex = 78;
            this.Edit_btu.Text = "Edit";
            this.Edit_btu.UseVisualStyleBackColor = true;
            this.Edit_btu.Click += new System.EventHandler(this.Edit_btu_Click);
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(731, 438);
            this.exit_but.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(116, 42);
            this.exit_but.TabIndex = 77;
            this.exit_but.Text = "Exit";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // Reset_but
            // 
            this.Reset_but.Location = new System.Drawing.Point(604, 438);
            this.Reset_but.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset_but.Name = "Reset_but";
            this.Reset_but.Size = new System.Drawing.Size(116, 42);
            this.Reset_but.TabIndex = 76;
            this.Reset_but.Text = "Reset";
            this.Reset_but.UseVisualStyleBackColor = true;
            this.Reset_but.Click += new System.EventHandler(this.Reset_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_price_Qunt);
            this.Controls.Add(this.text_Total_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_To_Quntity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcompany);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.Add_but);
            this.Controls.Add(this.Edit_btu);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.Reset_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentsForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox EquipmentList;
        private System.Windows.Forms.Label equipmentCountLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_price_Qunt;
        private System.Windows.Forms.TextBox text_Total_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_To_Quntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcompany;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.Button Edit_btu;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button Reset_but;
    }
}