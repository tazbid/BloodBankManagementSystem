namespace Online_Blood_Bank
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            this.groupBox_SignUp = new System.Windows.Forms.GroupBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_SignUp_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_SignUp_Password = new System.Windows.Forms.TextBox();
            this.textBox_SignUp_UserName = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_SignUp_UserName = new System.Windows.Forms.Label();
            this.groupBox_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SignUp
            // 
            this.groupBox_SignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_SignUp.Controls.Add(this.button_Back);
            this.groupBox_SignUp.Controls.Add(this.button_SignUp);
            this.groupBox_SignUp.Controls.Add(this.label_Email);
            this.groupBox_SignUp.Controls.Add(this.textBox_Email);
            this.groupBox_SignUp.Controls.Add(this.textBox_SignUp_ConfirmPassword);
            this.groupBox_SignUp.Controls.Add(this.textBox_SignUp_Password);
            this.groupBox_SignUp.Controls.Add(this.textBox_SignUp_UserName);
            this.groupBox_SignUp.Controls.Add(this.label_ConfirmPassword);
            this.groupBox_SignUp.Controls.Add(this.label_Password);
            this.groupBox_SignUp.Controls.Add(this.label_SignUp_UserName);
            this.groupBox_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_SignUp.Location = new System.Drawing.Point(56, 12);
            this.groupBox_SignUp.Name = "groupBox_SignUp";
            this.groupBox_SignUp.Size = new System.Drawing.Size(540, 258);
            this.groupBox_SignUp.TabIndex = 1;
            this.groupBox_SignUp.TabStop = false;
            this.groupBox_SignUp.Text = "Sign Up:";
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.Brown;
            this.button_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Back.Location = new System.Drawing.Point(431, 211);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(87, 41);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.Brown;
            this.button_SignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_SignUp.Location = new System.Drawing.Point(431, 164);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(87, 41);
            this.button_SignUp.TabIndex = 3;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(290, 43);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(68, 24);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "E-mail:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(294, 70);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(224, 29);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_SignUp_ConfirmPassword
            // 
            this.textBox_SignUp_ConfirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SignUp_ConfirmPassword.Location = new System.Drawing.Point(294, 129);
            this.textBox_SignUp_ConfirmPassword.Name = "textBox_SignUp_ConfirmPassword";
            this.textBox_SignUp_ConfirmPassword.PasswordChar = '*';
            this.textBox_SignUp_ConfirmPassword.Size = new System.Drawing.Size(224, 29);
            this.textBox_SignUp_ConfirmPassword.TabIndex = 2;
            // 
            // textBox_SignUp_Password
            // 
            this.textBox_SignUp_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SignUp_Password.Location = new System.Drawing.Point(55, 129);
            this.textBox_SignUp_Password.Name = "textBox_SignUp_Password";
            this.textBox_SignUp_Password.PasswordChar = '*';
            this.textBox_SignUp_Password.Size = new System.Drawing.Size(214, 29);
            this.textBox_SignUp_Password.TabIndex = 1;
            // 
            // textBox_SignUp_UserName
            // 
            this.textBox_SignUp_UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_SignUp_UserName.Location = new System.Drawing.Point(55, 70);
            this.textBox_SignUp_UserName.Name = "textBox_SignUp_UserName";
            this.textBox_SignUp_UserName.Size = new System.Drawing.Size(214, 29);
            this.textBox_SignUp_UserName.TabIndex = 0;
            this.textBox_SignUp_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SignUp_UserName_KeyPress);
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(290, 102);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.label_ConfirmPassword.TabIndex = 0;
            this.label_ConfirmPassword.Text = "Confirm Password:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(51, 102);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 24);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password:";
            // 
            // label_SignUp_UserName
            // 
            this.label_SignUp_UserName.AutoSize = true;
            this.label_SignUp_UserName.Location = new System.Drawing.Point(51, 43);
            this.label_SignUp_UserName.Name = "label_SignUp_UserName";
            this.label_SignUp_UserName.Size = new System.Drawing.Size(110, 24);
            this.label_SignUp_UserName.TabIndex = 0;
            this.label_SignUp_UserName.Text = "User Name:";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 551);
            this.Controls.Add(this.groupBox_SignUp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_SignUp.ResumeLayout(false);
            this.groupBox_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_SignUp;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_SignUp_UserName;
        private System.Windows.Forms.TextBox textBox_SignUp_UserName;
        private System.Windows.Forms.TextBox textBox_SignUp_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_SignUp_Password;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
    }
}