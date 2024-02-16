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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoItem = new System.Windows.Forms.PictureBox();
            this.NoItemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NoItemContainer
            // 
            this.NoItemContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoItemContainer.Controls.Add(this.label2);
            this.NoItemContainer.Controls.Add(this.label1);
            this.NoItemContainer.Controls.Add(this.NoItem);
            this.NoItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoItemContainer.Location = new System.Drawing.Point(0, 0);
            this.NoItemContainer.Name = "NoItemContainer";
            this.NoItemContainer.Size = new System.Drawing.Size(1015, 592);
            this.NoItemContainer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(68, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unfortunately there are no \r\ntickets available";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(115, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NoItem;
    }
}
