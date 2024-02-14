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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBaseControl));
            this.label5 = new System.Windows.Forms.Label();
            this.BTNCreate = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.ticketSubInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ticketSubInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(30, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(847, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // BTNCreate
            // 
            this.BTNCreate.AnimationHoverSpeed = 0.07F;
            this.BTNCreate.AnimationSpeed = 0.03F;
            this.BTNCreate.BackColor = System.Drawing.Color.Transparent;
            this.BTNCreate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNCreate.BorderColor = System.Drawing.Color.Black;
            this.BTNCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNCreate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNCreate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreate.ForeColor = System.Drawing.Color.White;
            this.BTNCreate.Image = null;
            this.BTNCreate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNCreate.Location = new System.Drawing.Point(948, 75);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNCreate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNCreate.OnHoverImage = null;
            this.BTNCreate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNCreate.Radius = 5;
            this.BTNCreate.Size = new System.Drawing.Size(135, 42);
            this.BTNCreate.TabIndex = 12;
            this.BTNCreate.Text = "Create";
            this.BTNCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Active Tickets";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(34, 132);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1113, 664);
            this.Container.TabIndex = 13;
            // 
            // ticketSubInfoBindingSource
            // 
            this.ticketSubInfoBindingSource.DataSource = typeof(TaskManagement.Models.TicketSubInfo);
            // 
            // TicketBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Container);
            this.Controls.Add(this.BTNCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketBaseControl";
            this.Size = new System.Drawing.Size(1180, 825);
            ((System.ComponentModel.ISupportInitialize)(this.ticketSubInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton BTNCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.BindingSource ticketSubInfoBindingSource;
    }
}
