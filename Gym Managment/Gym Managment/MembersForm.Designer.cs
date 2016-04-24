namespace Gym_Managment
{
    partial class MembersForm
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
            this.membersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.membersCountLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactnoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateofjoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.plantypeCombo = new System.Windows.Forms.ComboBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // membersList
            // 
            this.membersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersList.FormattingEnabled = true;
            this.membersList.ItemHeight = 16;
            this.membersList.Location = new System.Drawing.Point(6, 80);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(233, 388);
            this.membersList.TabIndex = 0;
            this.membersList.SelectedIndexChanged += new System.EventHandler(this.membersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Members List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Members Count : ";
            // 
            // membersCountLbl
            // 
            this.membersCountLbl.AutoSize = true;
            this.membersCountLbl.Location = new System.Drawing.Point(166, 29);
            this.membersCountLbl.Name = "membersCountLbl";
            this.membersCountLbl.Size = new System.Drawing.Size(16, 17);
            this.membersCountLbl.TabIndex = 3;
            this.membersCountLbl.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.membersList);
            this.groupBox1.Controls.Add(this.membersCountLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 526);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members Information";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(57, 482);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(127, 32);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Selected";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID : ";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(424, 36);
            this.idTxt.Multiline = true;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 22);
            this.idTxt.TabIndex = 6;
            this.idTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Location = new System.Drawing.Point(424, 72);
            this.firstnameTxt.Multiline = true;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(147, 22);
            this.firstnameTxt.TabIndex = 8;
            this.firstnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Location = new System.Drawing.Point(424, 109);
            this.lastnameTxt.Multiline = true;
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(147, 22);
            this.lastnameTxt.TabIndex = 10;
            this.lastnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name :";
            // 
            // contactnoTxt
            // 
            this.contactnoTxt.Location = new System.Drawing.Point(424, 147);
            this.contactnoTxt.Multiline = true;
            this.contactnoTxt.Name = "contactnoTxt";
            this.contactnoTxt.Size = new System.Drawing.Size(147, 22);
            this.contactnoTxt.TabIndex = 12;
            this.contactnoTxt.Text = "01";
            this.contactnoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact Number :";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(424, 189);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(419, 81);
            this.addressTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date Of Joining :";
            // 
            // dateofjoiningDate
            // 
            this.dateofjoiningDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateofjoiningDate.Location = new System.Drawing.Point(424, 297);
            this.dateofjoiningDate.Name = "dateofjoiningDate";
            this.dateofjoiningDate.Size = new System.Drawing.Size(251, 22);
            this.dateofjoiningDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Plan Type :";
            // 
            // plantypeCombo
            // 
            this.plantypeCombo.FormattingEnabled = true;
            this.plantypeCombo.Items.AddRange(new object[] {
            "Type1",
            "Type2",
            "Type3"});
            this.plantypeCombo.Location = new System.Drawing.Point(424, 333);
            this.plantypeCombo.Name = "plantypeCombo";
            this.plantypeCombo.Size = new System.Drawing.Size(147, 24);
            this.plantypeCombo.TabIndex = 18;
            this.plantypeCombo.Text = "Type1";
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.amountTxt.Location = new System.Drawing.Point(424, 379);
            this.amountTxt.Multiline = true;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(109, 22);
            this.amountTxt.TabIndex = 20;
            this.amountTxt.Text = "$0";
            this.amountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTxt.TextChanged += new System.EventHandler(this.amountTxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Amount : ";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(522, 470);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 42);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(613, 470);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 42);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(704, 470);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 42);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(431, 470);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(85, 42);
            this.resetBtn.TabIndex = 24;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 548);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.plantypeCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateofjoiningDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contactnoTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox membersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label membersCountLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactnoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateofjoiningDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox plantypeCombo;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}