namespace TaskManagement.UserControls.Components
{
    partial class AdminTicketCard
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
            this.BTNDelete = new Guna.UI.WinForms.GunaButton();
            this.BTNUpdate = new Guna.UI.WinForms.GunaButton();
            this.BTNView = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel4 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBDate = new System.Windows.Forms.Label();
            this.LBDescription = new System.Windows.Forms.Label();
            this.LBTitle = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.BTNDelete);
            this.gunaShadowPanel1.Controls.Add(this.BTNUpdate);
            this.gunaShadowPanel1.Controls.Add(this.BTNView);
            this.gunaShadowPanel1.Controls.Add(this.gunaShadowPanel4);
            this.gunaShadowPanel1.Controls.Add(this.LBDescription);
            this.gunaShadowPanel1.Controls.Add(this.LBTitle);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 3;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.gunaShadowPanel1.ShadowShift = 10;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(357, 190);
            this.gunaShadowPanel1.TabIndex = 7;
            // 
            // BTNDelete
            // 
            this.BTNDelete.AnimationHoverSpeed = 0.07F;
            this.BTNDelete.AnimationSpeed = 0.03F;
            this.BTNDelete.BackColor = System.Drawing.Color.Transparent;
            this.BTNDelete.BaseColor = System.Drawing.Color.Transparent;
            this.BTNDelete.BorderColor = System.Drawing.Color.Tomato;
            this.BTNDelete.BorderSize = 1;
            this.BTNDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BTNDelete.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.Color.Tomato;
            this.BTNDelete.Image = null;
            this.BTNDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNDelete.ImageOffsetX = 5;
            this.BTNDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNDelete.Location = new System.Drawing.Point(210, 132);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.BTNDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNDelete.OnHoverImage = null;
            this.BTNDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BTNDelete.Radius = 5;
            this.BTNDelete.Size = new System.Drawing.Size(50, 28);
            this.BTNDelete.TabIndex = 37;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.AnimationHoverSpeed = 0.07F;
            this.BTNUpdate.AnimationSpeed = 0.03F;
            this.BTNUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BTNUpdate.BaseColor = System.Drawing.Color.Transparent;
            this.BTNUpdate.BorderColor = System.Drawing.Color.DarkOrange;
            this.BTNUpdate.BorderSize = 1;
            this.BTNUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNUpdate.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.BTNUpdate.Image = null;
            this.BTNUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNUpdate.ImageOffsetX = 5;
            this.BTNUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNUpdate.Location = new System.Drawing.Point(149, 132);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.OnHoverBaseColor = System.Drawing.Color.DarkOrange;
            this.BTNUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNUpdate.OnHoverImage = null;
            this.BTNUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNUpdate.Radius = 5;
            this.BTNUpdate.Size = new System.Drawing.Size(50, 28);
            this.BTNUpdate.TabIndex = 36;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNView
            // 
            this.BTNView.AnimationHoverSpeed = 0.07F;
            this.BTNView.AnimationSpeed = 0.03F;
            this.BTNView.BackColor = System.Drawing.Color.Transparent;
            this.BTNView.BaseColor = System.Drawing.Color.Transparent;
            this.BTNView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNView.BorderSize = 1;
            this.BTNView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNView.FocusedColor = System.Drawing.Color.Empty;
            this.BTNView.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNView.Image = null;
            this.BTNView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNView.ImageOffsetX = 5;
            this.BTNView.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNView.Location = new System.Drawing.Point(88, 132);
            this.BTNView.Name = "BTNView";
            this.BTNView.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNView.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNView.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNView.OnHoverImage = null;
            this.BTNView.OnPressedColor = System.Drawing.Color.Black;
            this.BTNView.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BTNView.Radius = 5;
            this.BTNView.Size = new System.Drawing.Size(50, 28);
            this.BTNView.TabIndex = 35;
            this.BTNView.Text = "View";
            this.BTNView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNView.Click += new System.EventHandler(this.BTNView_Click);
            // 
            // gunaShadowPanel4
            // 
            this.gunaShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel4.Controls.Add(this.LBDate);
            this.gunaShadowPanel4.Location = new System.Drawing.Point(274, 24);
            this.gunaShadowPanel4.Name = "gunaShadowPanel4";
            this.gunaShadowPanel4.Radius = 3;
            this.gunaShadowPanel4.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel4.ShadowShift = 2;
            this.gunaShadowPanel4.Size = new System.Drawing.Size(56, 30);
            this.gunaShadowPanel4.TabIndex = 34;
            // 
            // LBDate
            // 
            this.LBDate.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDate.ForeColor = System.Drawing.Color.White;
            this.LBDate.Location = new System.Drawing.Point(7, 9);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(42, 13);
            this.LBDate.TabIndex = 6;
            this.LBDate.Text = "Aug 21";
            this.LBDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBDescription
            // 
            this.LBDescription.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDescription.Location = new System.Drawing.Point(34, 64);
            this.LBDescription.Name = "LBDescription";
            this.LBDescription.Size = new System.Drawing.Size(291, 54);
            this.LBDescription.TabIndex = 33;
            this.LBDescription.Text = "Lorem ipsum dolor sit amet, \r\nconsectetur adipiscing elit, sed \r\ndo eiusmod tempo" +
    "r incididunt ut labore et";
            // 
            // LBTitle
            // 
            this.LBTitle.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitle.Location = new System.Drawing.Point(34, 31);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(244, 22);
            this.LBTitle.TabIndex = 6;
            this.LBTitle.Text = "Sample";
            // 
            // TicketCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TicketCard";
            this.Size = new System.Drawing.Size(357, 190);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton BTNDelete;
        private Guna.UI.WinForms.GunaButton BTNUpdate;
        private Guna.UI.WinForms.GunaButton BTNView;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel4;
        private System.Windows.Forms.Label LBDate;
        private System.Windows.Forms.Label LBDescription;
        private System.Windows.Forms.Label LBTitle;
    }
}
