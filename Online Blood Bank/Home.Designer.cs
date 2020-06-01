namespace Online_Blood_Bank
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_LogIn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.button_Log_in = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_User_Id = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_User_Name = new System.Windows.Forms.Label();
            this.groupBox_LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_LogIn
            // 
            this.groupBox_LogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox_LogIn.Controls.Add(this.label1);
            this.groupBox_LogIn.Controls.Add(this.button_SignUp);
            this.groupBox_LogIn.Controls.Add(this.button_Log_in);
            this.groupBox_LogIn.Controls.Add(this.textBox_Password);
            this.groupBox_LogIn.Controls.Add(this.textBox_User_Id);
            this.groupBox_LogIn.Controls.Add(this.label_Password);
            this.groupBox_LogIn.Controls.Add(this.label_User_Name);
            this.groupBox_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_LogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_LogIn.Location = new System.Drawing.Point(12, 12);
            this.groupBox_LogIn.Name = "groupBox_LogIn";
            this.groupBox_LogIn.Size = new System.Drawing.Size(795, 127);
            this.groupBox_LogIn.TabIndex = 0;
            this.groupBox_LogIn.TabStop = false;
            this.groupBox_LogIn.Text = "Log-In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Here?";
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.Brown;
            this.button_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_SignUp.Location = new System.Drawing.Point(667, 73);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(93, 32);
            this.button_SignUp.TabIndex = 5;
            this.button_SignUp.Text = "Sign-Up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // button_Log_in
            // 
            this.button_Log_in.BackColor = System.Drawing.Color.Brown;
            this.button_Log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Log_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Log_in.Location = new System.Drawing.Point(667, 35);
            this.button_Log_in.Name = "button_Log_in";
            this.button_Log_in.Size = new System.Drawing.Size(93, 32);
            this.button_Log_in.TabIndex = 4;
            this.button_Log_in.Text = "Log In";
            this.button_Log_in.UseVisualStyleBackColor = false;
            this.button_Log_in.Click += new System.EventHandler(this.button_Log_in_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(473, 35);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(188, 29);
            this.textBox_Password.TabIndex = 3;
            // 
            // textBox_User_Id
            // 
            this.textBox_User_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_User_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_User_Id.Location = new System.Drawing.Point(163, 35);
            this.textBox_User_Id.Name = "textBox_User_Id";
            this.textBox_User_Id.Size = new System.Drawing.Size(201, 29);
            this.textBox_User_Id.TabIndex = 2;
            this.textBox_User_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_User_Id_KeyPress);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(370, 38);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 24);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // label_User_Name
            // 
            this.label_User_Name.AutoSize = true;
            this.label_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User_Name.Location = new System.Drawing.Point(47, 38);
            this.label_User_Name.Name = "label_User_Name";
            this.label_User_Name.Size = new System.Drawing.Size(110, 24);
            this.label_User_Name.TabIndex = 0;
            this.label_User_Name.Text = "User Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.groupBox_LogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_LogIn.ResumeLayout(false);
            this.groupBox_LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_LogIn;
        private System.Windows.Forms.Button button_Log_in;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_User_Id;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_User_Name;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label1;
    }
}

