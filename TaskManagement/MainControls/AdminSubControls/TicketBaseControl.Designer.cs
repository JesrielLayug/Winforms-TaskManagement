namespace TaskManagement.UserControls.AdminSubControls
{
    partial class TicketBaseControl
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
            this.BTNCreate = new Guna.UI.WinForms.GunaButton();
            this.Container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNSearch = new Guna.UI.WinForms.GunaButton();
            this.TBSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.AnimationHoverSpeed = 0.07F;
            this.BTNCreate.AnimationSpeed = 0.03F;
            this.BTNCreate.BackColor = System.Drawing.Color.Transparent;
            this.BTNCreate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.BTNCreate.BorderColor = System.Drawing.Color.White;
            this.BTNCreate.BorderSize = 1;
            this.BTNCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNCreate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNCreate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreate.ForeColor = System.Drawing.Color.White;
            this.BTNCreate.Image = null;
            this.BTNCreate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNCreate.Location = new System.Drawing.Point(1056, 14);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.BTNCreate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BTNCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNCreate.OnHoverImage = null;
            this.BTNCreate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNCreate.Radius = 5;
            this.BTNCreate.Size = new System.Drawing.Size(116, 34);
            this.BTNCreate.TabIndex = 12;
            this.BTNCreate.Text = "Add Ticket";
            this.BTNCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Container.Location = new System.Drawing.Point(24, 88);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1148, 569);
            this.Container.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BTNCreate);
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Controls.Add(this.TBSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 59);
            this.panel1.TabIndex = 14;
            // 
            // BTNSearch
            // 
            this.BTNSearch.AnimationHoverSpeed = 0.07F;
            this.BTNSearch.AnimationSpeed = 0.03F;
            this.BTNSearch.BackColor = System.Drawing.Color.Transparent;
            this.BTNSearch.BaseColor = System.Drawing.Color.Transparent;
            this.BTNSearch.BorderColor = System.Drawing.Color.White;
            this.BTNSearch.BorderSize = 1;
            this.BTNSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNSearch.FocusedColor = System.Drawing.Color.Empty;
            this.BTNSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearch.ForeColor = System.Drawing.Color.White;
            this.BTNSearch.Image = null;
            this.BTNSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSearch.Location = new System.Drawing.Point(665, 12);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSearch.OnHoverImage = null;
            this.BTNSearch.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSearch.Radius = 5;
            this.BTNSearch.Size = new System.Drawing.Size(83, 34);
            this.BTNSearch.TabIndex = 39;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.BackColor = System.Drawing.Color.Transparent;
            this.TBSearch.BaseColor = System.Drawing.Color.White;
            this.TBSearch.BorderColor = System.Drawing.Color.Transparent;
            this.TBSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.TBSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBSearch.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSearch.Location = new System.Drawing.Point(424, 12);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.Radius = 5;
            this.TBSearch.SelectedText = "";
            this.TBSearch.Size = new System.Drawing.Size(235, 34);
            this.TBSearch.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active Tickets";
            // 
            // TicketBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Container);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketBaseControl";
            this.Size = new System.Drawing.Size(1202, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton BTNCreate;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton BTNSearch;
        private Guna.UI.WinForms.GunaTextBox TBSearch;
    }
}
