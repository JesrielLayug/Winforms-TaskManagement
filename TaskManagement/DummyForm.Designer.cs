namespace TaskManagement
{
    partial class DummyForm
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
            this.TBPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBAuthorization = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNClear = new Guna.UI.WinForms.GunaButton();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.CBGender = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFirstname = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBLastname = new Guna.UI.WinForms.GunaTextBox();
            this.TBEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBPosition = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.Transparent;
            this.TBPassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TBPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBPassword.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(277, 357);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '\0';
            this.TBPassword.Radius = 5;
            this.TBPassword.SelectedText = "";
            this.TBPassword.Size = new System.Drawing.Size(245, 36);
            this.TBPassword.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(276, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 56;
            this.label8.Text = "Password";
            // 
            // CBAuthorization
            // 
            this.CBAuthorization.BackColor = System.Drawing.Color.Transparent;
            this.CBAuthorization.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBAuthorization.BorderColor = System.Drawing.Color.Transparent;
            this.CBAuthorization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBAuthorization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBAuthorization.FocusedColor = System.Drawing.Color.Empty;
            this.CBAuthorization.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAuthorization.ForeColor = System.Drawing.Color.Black;
            this.CBAuthorization.FormattingEnabled = true;
            this.CBAuthorization.ItemHeight = 27;
            this.CBAuthorization.Items.AddRange(new object[] {
            "Allowed",
            "Blocked"});
            this.CBAuthorization.Location = new System.Drawing.Point(279, 74);
            this.CBAuthorization.Name = "CBAuthorization";
            this.CBAuthorization.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBAuthorization.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBAuthorization.Radius = 5;
            this.CBAuthorization.Size = new System.Drawing.Size(243, 33);
            this.CBAuthorization.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(276, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Authorization";
            // 
            // BTNClear
            // 
            this.BTNClear.AnimationHoverSpeed = 0.07F;
            this.BTNClear.AnimationSpeed = 0.03F;
            this.BTNClear.BackColor = System.Drawing.Color.Transparent;
            this.BTNClear.BaseColor = System.Drawing.Color.White;
            this.BTNClear.BorderColor = System.Drawing.Color.Red;
            this.BTNClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNClear.FocusedColor = System.Drawing.Color.Empty;
            this.BTNClear.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClear.ForeColor = System.Drawing.Color.Red;
            this.BTNClear.Image = global::TaskManagement.Properties.Resources.reload;
            this.BTNClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClear.ImageSize = new System.Drawing.Size(15, 15);
            this.BTNClear.Location = new System.Drawing.Point(492, 11);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNClear.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNClear.OnHoverImage = null;
            this.BTNClear.OnPressedColor = System.Drawing.Color.Black;
            this.BTNClear.Radius = 5;
            this.BTNClear.Size = new System.Drawing.Size(35, 29);
            this.BTNClear.TabIndex = 52;
            this.BTNClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BTNSubmit.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.ForeColor = System.Drawing.Color.White;
            this.BTNSubmit.Image = null;
            this.BTNSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSubmit.Location = new System.Drawing.Point(277, 404);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 5;
            this.BTNSubmit.Size = new System.Drawing.Size(245, 36);
            this.BTNSubmit.TabIndex = 51;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // CBGender
            // 
            this.CBGender.BackColor = System.Drawing.Color.Transparent;
            this.CBGender.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBGender.BorderColor = System.Drawing.Color.Transparent;
            this.CBGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBGender.FocusedColor = System.Drawing.Color.Empty;
            this.CBGender.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGender.ForeColor = System.Drawing.Color.Black;
            this.CBGender.FormattingEnabled = true;
            this.CBGender.ItemHeight = 27;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.CBGender.Location = new System.Drawing.Point(277, 188);
            this.CBGender.Name = "CBGender";
            this.CBGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBGender.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBGender.Radius = 5;
            this.CBGender.Size = new System.Drawing.Size(245, 33);
            this.CBGender.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(277, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(277, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 42;
            this.label2.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(274, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Employee Details";
            // 
            // TBFirstname
            // 
            this.TBFirstname.BackColor = System.Drawing.Color.Transparent;
            this.TBFirstname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBFirstname.BorderColor = System.Drawing.Color.Transparent;
            this.TBFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBFirstname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBFirstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBFirstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBFirstname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFirstname.Location = new System.Drawing.Point(278, 131);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.PasswordChar = '\0';
            this.TBFirstname.Radius = 5;
            this.TBFirstname.SelectedText = "";
            this.TBFirstname.Size = new System.Drawing.Size(114, 36);
            this.TBFirstname.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(405, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 44;
            this.label4.Text = "Lastname";
            // 
            // TBLastname
            // 
            this.TBLastname.BackColor = System.Drawing.Color.Transparent;
            this.TBLastname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBLastname.BorderColor = System.Drawing.Color.Transparent;
            this.TBLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLastname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBLastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBLastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBLastname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLastname.Location = new System.Drawing.Point(407, 131);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.PasswordChar = '\0';
            this.TBLastname.Radius = 5;
            this.TBLastname.SelectedText = "";
            this.TBLastname.Size = new System.Drawing.Size(115, 36);
            this.TBLastname.TabIndex = 43;
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
            this.TBEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(277, 299);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.Radius = 5;
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(245, 36);
            this.TBEmail.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(276, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 50;
            this.label9.Text = "Email";
            // 
            // CBPosition
            // 
            this.CBPosition.BackColor = System.Drawing.Color.Transparent;
            this.CBPosition.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBPosition.BorderColor = System.Drawing.Color.Transparent;
            this.CBPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBPosition.FocusedColor = System.Drawing.Color.Empty;
            this.CBPosition.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPosition.ForeColor = System.Drawing.Color.Black;
            this.CBPosition.FormattingEnabled = true;
            this.CBPosition.ItemHeight = 27;
            this.CBPosition.Items.AddRange(new object[] {
            "Chief Information Officer (CIO)",
            "Chief Technology Officer (CTO)",
            "IT Director",
            "Infrastructure Manager",
            "Network Administrator",
            "Systems Administrator",
            "Database Administrator (DBA)",
            "Security Engineer",
            "Software Developer",
            "Help Desk",
            "Project Manager",
            "Business Analyst"});
            this.CBPosition.Location = new System.Drawing.Point(278, 242);
            this.CBPosition.Name = "CBPosition";
            this.CBPosition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBPosition.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBPosition.Radius = 5;
            this.CBPosition.Size = new System.Drawing.Size(244, 33);
            this.CBPosition.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(275, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 46;
            this.label6.Text = "Position";
            // 
            // DummyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBAuthorization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBLastname);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBPosition);
            this.Controls.Add(this.label6);
            this.Name = "DummyForm";
            this.Text = "DummyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox TBPassword;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox CBAuthorization;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton BTNClear;
        private Guna.UI.WinForms.GunaButton BTNSubmit;
        private Guna.UI.WinForms.GunaComboBox CBGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TBFirstname;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox TBLastname;
        private Guna.UI.WinForms.GunaTextBox TBEmail;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaComboBox CBPosition;
        private System.Windows.Forms.Label label6;
    }
}