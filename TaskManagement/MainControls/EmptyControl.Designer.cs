namespace TaskManagement.UserControls
{
    partial class EmptyControl
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
            this.NoItemContainer = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoItem = new System.Windows.Forms.PictureBox();
            this.NoItemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NoItemContainer
            // 
            this.NoItemContainer.Controls.Add(this.gunaButton1);
            this.NoItemContainer.Controls.Add(this.label2);
            this.NoItemContainer.Controls.Add(this.label1);
            this.NoItemContainer.Controls.Add(this.NoItem);
            this.NoItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoItemContainer.Location = new System.Drawing.Point(0, 0);
            this.NoItemContainer.Name = "NoItemContainer";
            this.NoItemContainer.Size = new System.Drawing.Size(1015, 592);
            this.NoItemContainer.TabIndex = 3;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(145, 322);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(135, 42);
            this.gunaButton1.TabIndex = 14;
            this.gunaButton1.Text = "Create";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(70, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 62);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unfortunately there are no \r\ntickets available";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(127, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "No Tickets";
            // 
            // NoItem
            // 
            this.NoItem.Image = global::TaskManagement.Properties.Resources.Add_notes_bro;
            this.NoItem.Location = new System.Drawing.Point(430, 22);
            this.NoItem.Name = "NoItem";
            this.NoItem.Size = new System.Drawing.Size(547, 523);
            this.NoItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoItem.TabIndex = 0;
            this.NoItem.TabStop = false;
            // 
            // EmptyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoItemContainer);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmptyControl";
            this.Size = new System.Drawing.Size(1015, 592);
            this.NoItemContainer.ResumeLayout(false);
            this.NoItemContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NoItemContainer;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NoItem;
    }
}
