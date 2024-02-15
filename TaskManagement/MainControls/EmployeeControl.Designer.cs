namespace TaskManagement.MainControls
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNLogout = new System.Windows.Forms.Button();
            this.BTNSettings = new System.Windows.Forms.Button();
            this.BTNTicket = new System.Windows.Forms.Button();
            this.BTNDashboard = new System.Windows.Forms.Button();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Controls.Add(this.BTNLogout);
            this.gunaShadowPanel1.Controls.Add(this.BTNSettings);
            this.gunaShadowPanel1.Controls.Add(this.BTNTicket);
            this.gunaShadowPanel1.Controls.Add(this.BTNDashboard);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.ShadowShift = 0;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(62, 681);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 59);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(62, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1202, 681);
            this.MainPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManagement.Properties.Resources.app;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTNLogout
            // 
            this.BTNLogout.FlatAppearance.BorderSize = 0;
            this.BTNLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLogout.Image = global::TaskManagement.Properties.Resources.door;
            this.BTNLogout.Location = new System.Drawing.Point(-1, 190);
            this.BTNLogout.Name = "BTNLogout";
            this.BTNLogout.Size = new System.Drawing.Size(60, 41);
            this.BTNLogout.TabIndex = 5;
            this.BTNLogout.UseVisualStyleBackColor = true;
            // 
            // BTNSettings
            // 
            this.BTNSettings.FlatAppearance.BorderSize = 0;
            this.BTNSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSettings.Image = global::TaskManagement.Properties.Resources.message_gray;
            this.BTNSettings.Location = new System.Drawing.Point(-2, 149);
            this.BTNSettings.Name = "BTNSettings";
            this.BTNSettings.Size = new System.Drawing.Size(61, 41);
            this.BTNSettings.TabIndex = 4;
            this.BTNSettings.UseVisualStyleBackColor = true;
            // 
            // BTNTicket
            // 
            this.BTNTicket.FlatAppearance.BorderSize = 0;
            this.BTNTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTicket.Image = global::TaskManagement.Properties.Resources.task;
            this.BTNTicket.Location = new System.Drawing.Point(-1, 107);
            this.BTNTicket.Name = "BTNTicket";
            this.BTNTicket.Size = new System.Drawing.Size(60, 41);
            this.BTNTicket.TabIndex = 1;
            this.BTNTicket.UseVisualStyleBackColor = true;
            // 
            // BTNDashboard
            // 
            this.BTNDashboard.FlatAppearance.BorderSize = 0;
            this.BTNDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDashboard.Image = global::TaskManagement.Properties.Resources.dashboard_3;
            this.BTNDashboard.Location = new System.Drawing.Point(0, 64);
            this.BTNDashboard.Name = "BTNDashboard";
            this.BTNDashboard.Size = new System.Drawing.Size(59, 41);
            this.BTNDashboard.TabIndex = 0;
            this.BTNDashboard.UseVisualStyleBackColor = true;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1264, 681);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNLogout;
        private System.Windows.Forms.Button BTNSettings;
        private System.Windows.Forms.Button BTNTicket;
        private System.Windows.Forms.Button BTNDashboard;
        private System.Windows.Forms.Panel MainPanel;
    }
}
