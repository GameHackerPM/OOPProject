namespace Gym_Managment.Equipments
{
    partial class EquipmentShowAll
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modeCombo = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.modeCombo);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(738, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Equipment Data Information";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(260, 20);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(139, 20);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 318);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modeCombo
            // 
            this.modeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeCombo.FormattingEnabled = true;
            this.modeCombo.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Date"});
            this.modeCombo.Location = new System.Drawing.Point(208, 19);
            this.modeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.modeCombo.Name = "modeCombo";
            this.modeCombo.Size = new System.Drawing.Size(48, 21);
            this.modeCombo.TabIndex = 1;
            this.modeCombo.SelectedIndexChanged += new System.EventHandler(this.modeCombo_SelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(494, 19);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 20);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear Filter";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(402, 19);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 20);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // EquipmentShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "EquipmentShowAll";
            this.Text = "EquipmentShowAll";
            this.Load += new System.EventHandler(this.equipmentShow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox modeCombo;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}