namespace TaskManagement.Views
{
    partial class ForgotPassword
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
            this.CBShowPassword = new Guna.UI.WinForms.GunaCheckBox();
            this.TBEmail = new Guna.UI.WinForms.GunaTextBox();
            this.TBNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.LBEmail = new System.Windows.Forms.Label();
            this.LBNewPassword = new System.Windows.Forms.Label();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // CBShowPassword
            // 
            this.CBShowPassword.BaseColor = System.Drawing.Color.White;
            this.CBShowPassword.CheckedOffColor = System.Drawing.Color.Gray;
            this.CBShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.CBShowPassword.FillColor = System.Drawing.Color.White;
            this.CBShowPassword.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBShowPassword.Location = new System.Drawing.Point(47, 136);
            this.CBShowPassword.Name = "CBShowPassword";
            this.CBShowPassword.Size = new System.Drawing.Size(111, 20);
            this.CBShowPassword.TabIndex = 14;
            this.CBShowPassword.Text = "Show Password";
            this.CBShowPassword.CheckedChanged += new System.EventHandler(this.CBShowPassword_CheckedChanged);
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.Color.Transparent;
            this.TBEmail.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBEmail.BorderColor = System.Drawing.Color.Transparent;
            this.TBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.TBEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBEmail.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(47, 38);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.Radius = 5;
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(197, 33);
            this.TBEmail.TabIndex = 10;
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.TBNewPassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TBNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TBNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBNewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBNewPassword.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNewPassword.Location = new System.Drawing.Point(47, 96);
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.PasswordChar = '●';
            this.TBNewPassword.Radius = 5;
            this.TBNewPassword.SelectedText = "";
            this.TBNewPassword.Size = new System.Drawing.Size(197, 34);
            this.TBNewPassword.TabIndex = 11;
            // 
            // LBEmail
            // 
            this.LBEmail.AutoSize = true;
            this.LBEmail.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.LBEmail.Location = new System.Drawing.Point(44, 20);
            this.LBEmail.Name = "LBEmail";
            this.LBEmail.Size = new System.Drawing.Size(40, 15);
            this.LBEmail.TabIndex = 12;
            this.LBEmail.Text = "Email";
            // 
            // LBNewPassword
            // 
            this.LBNewPassword.AutoSize = true;
            this.LBNewPassword.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.LBNewPassword.Location = new System.Drawing.Point(44, 78);
            this.LBNewPassword.Name = "LBNewPassword";
            this.LBNewPassword.Size = new System.Drawing.Size(92, 15);
            this.LBNewPassword.TabIndex = 13;
            this.LBNewPassword.Text = "New Password";
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.AnimationHoverSpeed = 0.07F;
            this.BTNSubmit.AnimationSpeed = 0.03F;
            this.BTNSubmit.BackColor = System.Drawing.Color.Transparent;
            this.BTNSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNSubmit.BorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.BTNSubmit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.ForeColor = System.Drawing.Color.White;
            this.BTNSubmit.Image = null;
            this.BTNSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSubmit.Location = new System.Drawing.Point(47, 170);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 5;
            this.BTNSubmit.Size = new System.Drawing.Size(197, 34);
            this.BTNSubmit.TabIndex = 15;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 224);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.CBShowPassword);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBNewPassword);
            this.Controls.Add(this.LBEmail);
            this.Controls.Add(this.LBNewPassword);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox CBShowPassword;
        private Guna.UI.WinForms.GunaTextBox TBEmail;
        private Guna.UI.WinForms.GunaTextBox TBNewPassword;
        private System.Windows.Forms.Label LBEmail;
        private System.Windows.Forms.Label LBNewPassword;
        private Guna.UI.WinForms.GunaButton BTNSubmit;
    }
}