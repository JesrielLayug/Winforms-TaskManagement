namespace TaskManagement.Views
{
    partial class LoginView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBEmail = new Guna.UI.WinForms.GunaTextBox();
            this.TBPassword = new Guna.UI.WinForms.GunaTextBox();
            this.BTNLogin = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBShowPassword = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManagement.Properties.Resources.Team_work_amico;
            this.pictureBox1.Location = new System.Drawing.Point(83, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.Color.Transparent;
            this.TBEmail.BaseColor = System.Drawing.Color.White;
            this.TBEmail.BorderColor = System.Drawing.Color.Silver;
            this.TBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.TBEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(51, 148);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.Radius = 5;
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(210, 39);
            this.TBEmail.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.Transparent;
            this.TBPassword.BaseColor = System.Drawing.Color.White;
            this.TBPassword.BorderColor = System.Drawing.Color.Silver;
            this.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TBPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBPassword.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(51, 222);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '●';
            this.TBPassword.Radius = 5;
            this.TBPassword.SelectedText = "";
            this.TBPassword.Size = new System.Drawing.Size(210, 39);
            this.TBPassword.TabIndex = 2;
            // 
            // BTNLogin
            // 
            this.BTNLogin.AnimationHoverSpeed = 0.07F;
            this.BTNLogin.AnimationSpeed = 0.03F;
            this.BTNLogin.BackColor = System.Drawing.Color.Transparent;
            this.BTNLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNLogin.BorderColor = System.Drawing.Color.Black;
            this.BTNLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNLogin.FocusedColor = System.Drawing.Color.Empty;
            this.BTNLogin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.ForeColor = System.Drawing.Color.White;
            this.BTNLogin.Image = null;
            this.BTNLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNLogin.Location = new System.Drawing.Point(51, 317);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNLogin.OnHoverImage = null;
            this.BTNLogin.OnPressedColor = System.Drawing.Color.Black;
            this.BTNLogin.Radius = 5;
            this.BTNLogin.Size = new System.Drawing.Size(210, 42);
            this.BTNLogin.TabIndex = 3;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(47, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(170, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departmental";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(127, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Task Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(122, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Streamlining Tasks, Empowering Departments.";
            // 
            // CBShowPassword
            // 
            this.CBShowPassword.BaseColor = System.Drawing.Color.White;
            this.CBShowPassword.CheckedOffColor = System.Drawing.Color.Gray;
            this.CBShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.CBShowPassword.FillColor = System.Drawing.Color.White;
            this.CBShowPassword.Location = new System.Drawing.Point(51, 276);
            this.CBShowPassword.Name = "CBShowPassword";
            this.CBShowPassword.Size = new System.Drawing.Size(111, 20);
            this.CBShowPassword.TabIndex = 9;
            this.CBShowPassword.Text = "Show Password";
            this.CBShowPassword.CheckedChanged += new System.EventHandler(this.CBShowPassword_CheckedChanged);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.Controls.Add(this.label7);
            this.gunaShadowPanel1.Controls.Add(this.label6);
            this.gunaShadowPanel1.Controls.Add(this.BTNLogin);
            this.gunaShadowPanel1.Controls.Add(this.CBShowPassword);
            this.gunaShadowPanel1.Controls.Add(this.TBEmail);
            this.gunaShadowPanel1.Controls.Add(this.TBPassword);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(547, 104);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 8;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(316, 386);
            this.gunaShadowPanel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(77, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Glad to see you again!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(108, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox TBEmail;
        private Guna.UI.WinForms.GunaTextBox TBPassword;
        private Guna.UI.WinForms.GunaButton BTNLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaCheckBox CBShowPassword;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}