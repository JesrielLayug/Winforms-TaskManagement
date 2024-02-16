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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.AnimationHoverSpeed = 0.07F;
            this.BTNCreate.AnimationSpeed = 0.03F;
            this.BTNCreate.BackColor = System.Drawing.Color.Transparent;
            this.BTNCreate.BaseColor = System.Drawing.Color.Transparent;
            this.BTNCreate.BorderColor = System.Drawing.Color.White;
            this.BTNCreate.BorderSize = 1;
            this.BTNCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNCreate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNCreate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreate.ForeColor = System.Drawing.Color.White;
            this.BTNCreate.Image = null;
            this.BTNCreate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNCreate.Location = new System.Drawing.Point(1076, 14);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.BTNCreate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BTNCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNCreate.OnHoverImage = null;
            this.BTNCreate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNCreate.Radius = 5;
            this.BTNCreate.Size = new System.Drawing.Size(96, 36);
            this.BTNCreate.TabIndex = 12;
            this.BTNCreate.Text = "Create";
            this.BTNCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Container.Location = new System.Drawing.Point(24, 76);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1148, 581);
            this.Container.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BTNCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 59);
            this.panel1.TabIndex = 14;
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
    }
}
