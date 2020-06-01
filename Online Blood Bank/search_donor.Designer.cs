namespace Online_Blood_Bank
{
    partial class Search_donor
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
            this.comboBox_SearchDonor_BloodGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SearchDonor_SelectDivision = new System.Windows.Forms.ComboBox();
            this.label_SearchDonor_SelectDivision = new System.Windows.Forms.Label();
            this.comboBox_SearchDonor_SelectCity = new System.Windows.Forms.ComboBox();
            this.label_SearchDonor_SelectCity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_SearchDonor = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.groupBoxSearchDonor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearchDonor.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_SearchDonor_BloodGroup
            // 
            this.comboBox_SearchDonor_BloodGroup.FormattingEnabled = true;
            this.comboBox_SearchDonor_BloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox_SearchDonor_BloodGroup.Location = new System.Drawing.Point(197, 34);
            this.comboBox_SearchDonor_BloodGroup.Name = "comboBox_SearchDonor_BloodGroup";
            this.comboBox_SearchDonor_BloodGroup.Size = new System.Drawing.Size(188, 28);
            this.comboBox_SearchDonor_BloodGroup.TabIndex = 0;
            this.comboBox_SearchDonor_BloodGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_SearchDonor_BloodGroup_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Blood Group:";
            // 
            // comboBox_SearchDonor_SelectDivision
            // 
            this.comboBox_SearchDonor_SelectDivision.FormattingEnabled = true;
            this.comboBox_SearchDonor_SelectDivision.Items.AddRange(new object[] {
            "Barishal",
            "Chittagong",
            "Dhaka",
            "Khulna",
            "Mymensingh",
            "Rajshahi",
            "Sylhet",
            "Rangpur"});
            this.comboBox_SearchDonor_SelectDivision.Location = new System.Drawing.Point(197, 68);
            this.comboBox_SearchDonor_SelectDivision.Name = "comboBox_SearchDonor_SelectDivision";
            this.comboBox_SearchDonor_SelectDivision.Size = new System.Drawing.Size(188, 28);
            this.comboBox_SearchDonor_SelectDivision.TabIndex = 0;
            this.comboBox_SearchDonor_SelectDivision.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchDonor_SelectDivision_SelectedIndexChanged);
            this.comboBox_SearchDonor_SelectDivision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_SearchDonor_SelectDivision_KeyPress);
            // 
            // label_SearchDonor_SelectDivision
            // 
            this.label_SearchDonor_SelectDivision.AutoSize = true;
            this.label_SearchDonor_SelectDivision.Location = new System.Drawing.Point(75, 71);
            this.label_SearchDonor_SelectDivision.Name = "label_SearchDonor_SelectDivision";
            this.label_SearchDonor_SelectDivision.Size = new System.Drawing.Size(116, 20);
            this.label_SearchDonor_SelectDivision.TabIndex = 1;
            this.label_SearchDonor_SelectDivision.Text = "Select Division:";
            // 
            // comboBox_SearchDonor_SelectCity
            // 
            this.comboBox_SearchDonor_SelectCity.FormattingEnabled = true;
            this.comboBox_SearchDonor_SelectCity.Location = new System.Drawing.Point(197, 102);
            this.comboBox_SearchDonor_SelectCity.Name = "comboBox_SearchDonor_SelectCity";
            this.comboBox_SearchDonor_SelectCity.Size = new System.Drawing.Size(188, 28);
            this.comboBox_SearchDonor_SelectCity.TabIndex = 0;
            this.comboBox_SearchDonor_SelectCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_SearchDonor_SelectCity_KeyPress);
            // 
            // label_SearchDonor_SelectCity
            // 
            this.label_SearchDonor_SelectCity.AutoSize = true;
            this.label_SearchDonor_SelectCity.Location = new System.Drawing.Point(103, 105);
            this.label_SearchDonor_SelectCity.Name = "label_SearchDonor_SelectCity";
            this.label_SearchDonor_SelectCity.Size = new System.Drawing.Size(88, 20);
            this.label_SearchDonor_SelectCity.TabIndex = 1;
            this.label_SearchDonor_SelectCity.Text = "Select City:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_SearchDonor
            // 
            this.button_SearchDonor.BackColor = System.Drawing.Color.Brown;
            this.button_SearchDonor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_SearchDonor.Location = new System.Drawing.Point(298, 136);
            this.button_SearchDonor.Name = "button_SearchDonor";
            this.button_SearchDonor.Size = new System.Drawing.Size(87, 41);
            this.button_SearchDonor.TabIndex = 3;
            this.button_SearchDonor.Text = "Search";
            this.button_SearchDonor.UseVisualStyleBackColor = false;
            this.button_SearchDonor.Click += new System.EventHandler(this.button_SearchDonor_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Brown;
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(298, 183);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 41);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // groupBoxSearchDonor
            // 
            this.groupBoxSearchDonor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxSearchDonor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxSearchDonor.Controls.Add(this.button_SearchDonor);
            this.groupBoxSearchDonor.Controls.Add(this.button_back);
            this.groupBoxSearchDonor.Controls.Add(this.comboBox_SearchDonor_BloodGroup);
            this.groupBoxSearchDonor.Controls.Add(this.comboBox_SearchDonor_SelectDivision);
            this.groupBoxSearchDonor.Controls.Add(this.comboBox_SearchDonor_SelectCity);
            this.groupBoxSearchDonor.Controls.Add(this.label_SearchDonor_SelectCity);
            this.groupBoxSearchDonor.Controls.Add(this.label1);
            this.groupBoxSearchDonor.Controls.Add(this.label_SearchDonor_SelectDivision);
            this.groupBoxSearchDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchDonor.Location = new System.Drawing.Point(343, 12);
            this.groupBoxSearchDonor.Name = "groupBoxSearchDonor";
            this.groupBoxSearchDonor.Size = new System.Drawing.Size(417, 255);
            this.groupBoxSearchDonor.TabIndex = 5;
            this.groupBoxSearchDonor.TabStop = false;
            this.groupBoxSearchDonor.Text = "Search:";
            // 
            // Search_donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 715);
            this.Controls.Add(this.groupBoxSearchDonor);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Search_donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Blood Donor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearchDonor.ResumeLayout(false);
            this.groupBoxSearchDonor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SearchDonor_BloodGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SearchDonor_SelectDivision;
        private System.Windows.Forms.Label label_SearchDonor_SelectDivision;
        private System.Windows.Forms.ComboBox comboBox_SearchDonor_SelectCity;
        private System.Windows.Forms.Label label_SearchDonor_SelectCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_SearchDonor;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox groupBoxSearchDonor;
    }
}