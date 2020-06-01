namespace Online_Blood_Bank
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.button_register = new System.Windows.Forms.Button();
            this.label_Profile_Name = new System.Windows.Forms.Label();
            this.button_Search_donor = new System.Windows.Forms.Button();
            this.groupBox_profile = new System.Windows.Forms.GroupBox();
            this.butto_UpdateProfile = new System.Windows.Forms.Button();
            this.button_unregister = new System.Windows.Forms.Button();
            this.button_delete_account = new System.Windows.Forms.Button();
            this.groupBox_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Brown;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_register.Location = new System.Drawing.Point(115, 38);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(268, 62);
            this.button_register.TabIndex = 0;
            this.button_register.Text = "Register as a Donor";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_Profile_Name
            // 
            this.label_Profile_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Profile_Name.AutoSize = true;
            this.label_Profile_Name.BackColor = System.Drawing.Color.PowderBlue;
            this.label_Profile_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Profile_Name.Location = new System.Drawing.Point(6, 0);
            this.label_Profile_Name.Name = "label_Profile_Name";
            this.label_Profile_Name.Size = new System.Drawing.Size(97, 24);
            this.label_Profile_Name.TabIndex = 1;
            this.label_Profile_Name.Text = "Username";
            // 
            // button_Search_donor
            // 
            this.button_Search_donor.BackColor = System.Drawing.Color.Brown;
            this.button_Search_donor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_donor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search_donor.Location = new System.Drawing.Point(115, 106);
            this.button_Search_donor.Name = "button_Search_donor";
            this.button_Search_donor.Size = new System.Drawing.Size(268, 62);
            this.button_Search_donor.TabIndex = 3;
            this.button_Search_donor.Text = "Search for Donor";
            this.button_Search_donor.UseVisualStyleBackColor = false;
            this.button_Search_donor.Click += new System.EventHandler(this.button_Search_donor_Click);
            // 
            // groupBox_profile
            // 
            this.groupBox_profile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_profile.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_profile.Controls.Add(this.butto_UpdateProfile);
            this.groupBox_profile.Controls.Add(this.button_unregister);
            this.groupBox_profile.Controls.Add(this.button_delete_account);
            this.groupBox_profile.Controls.Add(this.button_register);
            this.groupBox_profile.Controls.Add(this.button_Search_donor);
            this.groupBox_profile.Controls.Add(this.label_Profile_Name);
            this.groupBox_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_profile.Location = new System.Drawing.Point(190, 118);
            this.groupBox_profile.Name = "groupBox_profile";
            this.groupBox_profile.Size = new System.Drawing.Size(479, 388);
            this.groupBox_profile.TabIndex = 5;
            this.groupBox_profile.TabStop = false;
            // 
            // butto_UpdateProfile
            // 
            this.butto_UpdateProfile.BackColor = System.Drawing.Color.Brown;
            this.butto_UpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto_UpdateProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butto_UpdateProfile.Location = new System.Drawing.Point(115, 310);
            this.butto_UpdateProfile.Name = "butto_UpdateProfile";
            this.butto_UpdateProfile.Size = new System.Drawing.Size(268, 62);
            this.butto_UpdateProfile.TabIndex = 6;
            this.butto_UpdateProfile.Text = "Update Profile";
            this.butto_UpdateProfile.UseVisualStyleBackColor = false;
            this.butto_UpdateProfile.Click += new System.EventHandler(this.butto_UpdateProfile_Click);
            // 
            // button_unregister
            // 
            this.button_unregister.BackColor = System.Drawing.Color.Brown;
            this.button_unregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_unregister.Location = new System.Drawing.Point(115, 242);
            this.button_unregister.Name = "button_unregister";
            this.button_unregister.Size = new System.Drawing.Size(268, 62);
            this.button_unregister.TabIndex = 5;
            this.button_unregister.Text = "Unregister as a Donor";
            this.button_unregister.UseVisualStyleBackColor = false;
            this.button_unregister.Click += new System.EventHandler(this.button_unregister_Click);
            // 
            // button_delete_account
            // 
            this.button_delete_account.BackColor = System.Drawing.Color.Brown;
            this.button_delete_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete_account.Location = new System.Drawing.Point(115, 174);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(268, 62);
            this.button_delete_account.TabIndex = 4;
            this.button_delete_account.Text = "Delete Account";
            this.button_delete_account.UseVisualStyleBackColor = false;
            this.button_delete_account.Click += new System.EventHandler(this.button_delete_account_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 607);
            this.Controls.Add(this.groupBox_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_profile.ResumeLayout(false);
            this.groupBox_profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_Profile_Name;
        private System.Windows.Forms.Button button_Search_donor;
        private System.Windows.Forms.GroupBox groupBox_profile;
        private System.Windows.Forms.Button button_unregister;
        private System.Windows.Forms.Button button_delete_account;
        private System.Windows.Forms.Button butto_UpdateProfile;
    }
}