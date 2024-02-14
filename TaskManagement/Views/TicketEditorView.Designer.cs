namespace TaskManagement.Views
{
    partial class TicketEditorView
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
            this.TBTitle = new Guna.UI.WinForms.GunaTextBox();
            this.CBAssignTo = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBPriority = new Guna.UI.WinForms.GunaComboBox();
            this.TBDescription = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBTaskStatus = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBStartDate = new Guna.UI.WinForms.GunaTextBox();
            this.TBDueDate = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BTNDueDate = new Guna.UI.WinForms.GunaButton();
            this.BTNStartDate = new Guna.UI.WinForms.GunaButton();
            this.CBCreator = new Guna.UI.WinForms.GunaComboBox();
            this.CBDivision = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // TBTitle
            // 
            this.TBTitle.BackColor = System.Drawing.Color.Transparent;
            this.TBTitle.BaseColor = System.Drawing.Color.White;
            this.TBTitle.BorderColor = System.Drawing.Color.Silver;
            this.TBTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBTitle.FocusedBaseColor = System.Drawing.Color.White;
            this.TBTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBTitle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitle.Location = new System.Drawing.Point(47, 143);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.PasswordChar = '\0';
            this.TBTitle.Radius = 5;
            this.TBTitle.SelectedText = "";
            this.TBTitle.Size = new System.Drawing.Size(218, 39);
            this.TBTitle.TabIndex = 9;
            // 
            // CBAssignTo
            // 
            this.CBAssignTo.BackColor = System.Drawing.Color.Transparent;
            this.CBAssignTo.BaseColor = System.Drawing.Color.White;
            this.CBAssignTo.BorderColor = System.Drawing.Color.Silver;
            this.CBAssignTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBAssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAssignTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBAssignTo.FocusedColor = System.Drawing.Color.Empty;
            this.CBAssignTo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAssignTo.ForeColor = System.Drawing.Color.Black;
            this.CBAssignTo.FormattingEnabled = true;
            this.CBAssignTo.ItemHeight = 31;
            this.CBAssignTo.Location = new System.Drawing.Point(47, 214);
            this.CBAssignTo.Name = "CBAssignTo";
            this.CBAssignTo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBAssignTo.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBAssignTo.Radius = 5;
            this.CBAssignTo.Size = new System.Drawing.Size(218, 37);
            this.CBAssignTo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(44, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Assign To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(44, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Issuer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(293, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Division";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(293, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Priority";
            // 
            // CBPriority
            // 
            this.CBPriority.BackColor = System.Drawing.Color.Transparent;
            this.CBPriority.BaseColor = System.Drawing.Color.White;
            this.CBPriority.BorderColor = System.Drawing.Color.Silver;
            this.CBPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPriority.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBPriority.FocusedColor = System.Drawing.Color.Empty;
            this.CBPriority.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPriority.ForeColor = System.Drawing.Color.Black;
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.ItemHeight = 31;
            this.CBPriority.Items.AddRange(new object[] {
            "High Priority",
            "Medium Priority",
            "Low Priority"});
            this.CBPriority.Location = new System.Drawing.Point(297, 214);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBPriority.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBPriority.Radius = 5;
            this.CBPriority.Size = new System.Drawing.Size(218, 37);
            this.CBPriority.TabIndex = 17;
            // 
            // TBDescription
            // 
            this.TBDescription.BackColor = System.Drawing.Color.Transparent;
            this.TBDescription.BaseColor = System.Drawing.Color.White;
            this.TBDescription.BorderColor = System.Drawing.Color.Silver;
            this.TBDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.TBDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBDescription.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescription.Location = new System.Drawing.Point(47, 442);
            this.TBDescription.Multiline = true;
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.PasswordChar = '\0';
            this.TBDescription.Radius = 5;
            this.TBDescription.SelectedText = "";
            this.TBDescription.Size = new System.Drawing.Size(468, 124);
            this.TBDescription.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(43, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Description";
            // 
            // CBTaskStatus
            // 
            this.CBTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBTaskStatus.BaseColor = System.Drawing.Color.White;
            this.CBTaskStatus.BorderColor = System.Drawing.Color.Silver;
            this.CBTaskStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTaskStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBTaskStatus.FocusedColor = System.Drawing.Color.Empty;
            this.CBTaskStatus.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTaskStatus.ForeColor = System.Drawing.Color.Black;
            this.CBTaskStatus.FormattingEnabled = true;
            this.CBTaskStatus.ItemHeight = 31;
            this.CBTaskStatus.Items.AddRange(new object[] {
            "Next Up",
            "In Progress",
            "Completed"});
            this.CBTaskStatus.Location = new System.Drawing.Point(297, 145);
            this.CBTaskStatus.Name = "CBTaskStatus";
            this.CBTaskStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBTaskStatus.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBTaskStatus.Radius = 5;
            this.CBTaskStatus.Size = new System.Drawing.Size(218, 37);
            this.CBTaskStatus.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(293, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Task Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(43, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Start Date";
            // 
            // TBStartDate
            // 
            this.TBStartDate.BackColor = System.Drawing.Color.Transparent;
            this.TBStartDate.BaseColor = System.Drawing.Color.White;
            this.TBStartDate.BorderColor = System.Drawing.Color.Silver;
            this.TBStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBStartDate.FocusedBaseColor = System.Drawing.Color.White;
            this.TBStartDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBStartDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBStartDate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStartDate.Location = new System.Drawing.Point(47, 364);
            this.TBStartDate.Name = "TBStartDate";
            this.TBStartDate.PasswordChar = '\0';
            this.TBStartDate.Radius = 5;
            this.TBStartDate.SelectedText = "";
            this.TBStartDate.Size = new System.Drawing.Size(165, 39);
            this.TBStartDate.TabIndex = 25;
            // 
            // TBDueDate
            // 
            this.TBDueDate.BackColor = System.Drawing.Color.Transparent;
            this.TBDueDate.BaseColor = System.Drawing.Color.White;
            this.TBDueDate.BorderColor = System.Drawing.Color.Silver;
            this.TBDueDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBDueDate.FocusedBaseColor = System.Drawing.Color.White;
            this.TBDueDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBDueDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBDueDate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDueDate.Location = new System.Drawing.Point(297, 364);
            this.TBDueDate.Name = "TBDueDate";
            this.TBDueDate.PasswordChar = '\0';
            this.TBDueDate.Radius = 5;
            this.TBDueDate.SelectedText = "";
            this.TBDueDate.Size = new System.Drawing.Size(165, 39);
            this.TBDueDate.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label10.Location = new System.Drawing.Point(293, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Due Date";
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
            this.BTNSubmit.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.ForeColor = System.Drawing.Color.White;
            this.BTNSubmit.Image = null;
            this.BTNSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSubmit.Location = new System.Drawing.Point(305, 585);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 5;
            this.BTNSubmit.Size = new System.Drawing.Size(210, 42);
            this.BTNSubmit.TabIndex = 28;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(185, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Create Task";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label11.Location = new System.Drawing.Point(117, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Generate Tasks for Enhanced Workflow Management";
            // 
            // BTNDueDate
            // 
            this.BTNDueDate.AnimationHoverSpeed = 0.07F;
            this.BTNDueDate.AnimationSpeed = 0.03F;
            this.BTNDueDate.BackColor = System.Drawing.Color.Transparent;
            this.BTNDueDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNDueDate.BorderColor = System.Drawing.Color.Black;
            this.BTNDueDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNDueDate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNDueDate.ForeColor = System.Drawing.Color.White;
            this.BTNDueDate.Image = global::TaskManagement.Properties.Resources.Calendar;
            this.BTNDueDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNDueDate.ImageOffsetX = 5;
            this.BTNDueDate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNDueDate.Location = new System.Drawing.Point(468, 364);
            this.BTNDueDate.Name = "BTNDueDate";
            this.BTNDueDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNDueDate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNDueDate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNDueDate.OnHoverImage = null;
            this.BTNDueDate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNDueDate.Radius = 5;
            this.BTNDueDate.Size = new System.Drawing.Size(47, 39);
            this.BTNDueDate.TabIndex = 31;
            this.BTNDueDate.Click += new System.EventHandler(this.BTNDueDate_Click);
            // 
            // BTNStartDate
            // 
            this.BTNStartDate.AnimationHoverSpeed = 0.07F;
            this.BTNStartDate.AnimationSpeed = 0.03F;
            this.BTNStartDate.BackColor = System.Drawing.Color.Transparent;
            this.BTNStartDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNStartDate.BorderColor = System.Drawing.Color.Black;
            this.BTNStartDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNStartDate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNStartDate.ForeColor = System.Drawing.Color.White;
            this.BTNStartDate.Image = global::TaskManagement.Properties.Resources.Calendar;
            this.BTNStartDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNStartDate.ImageOffsetX = 5;
            this.BTNStartDate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNStartDate.Location = new System.Drawing.Point(218, 364);
            this.BTNStartDate.Name = "BTNStartDate";
            this.BTNStartDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNStartDate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNStartDate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNStartDate.OnHoverImage = null;
            this.BTNStartDate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNStartDate.Radius = 5;
            this.BTNStartDate.Size = new System.Drawing.Size(47, 39);
            this.BTNStartDate.TabIndex = 30;
            this.BTNStartDate.Click += new System.EventHandler(this.BTNStartDate_Click);
            // 
            // CBCreator
            // 
            this.CBCreator.BackColor = System.Drawing.Color.Transparent;
            this.CBCreator.BaseColor = System.Drawing.Color.White;
            this.CBCreator.BorderColor = System.Drawing.Color.Silver;
            this.CBCreator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCreator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCreator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBCreator.FocusedColor = System.Drawing.Color.Empty;
            this.CBCreator.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCreator.ForeColor = System.Drawing.Color.Black;
            this.CBCreator.FormattingEnabled = true;
            this.CBCreator.ItemHeight = 31;
            this.CBCreator.Location = new System.Drawing.Point(47, 290);
            this.CBCreator.Name = "CBCreator";
            this.CBCreator.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBCreator.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBCreator.Radius = 5;
            this.CBCreator.Size = new System.Drawing.Size(218, 37);
            this.CBCreator.TabIndex = 32;
            // 
            // CBDivision
            // 
            this.CBDivision.BackColor = System.Drawing.Color.Transparent;
            this.CBDivision.BaseColor = System.Drawing.Color.White;
            this.CBDivision.BorderColor = System.Drawing.Color.Silver;
            this.CBDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDivision.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBDivision.FocusedColor = System.Drawing.Color.Empty;
            this.CBDivision.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDivision.ForeColor = System.Drawing.Color.Black;
            this.CBDivision.FormattingEnabled = true;
            this.CBDivision.ItemHeight = 31;
            this.CBDivision.Items.AddRange(new object[] {
            "Infrastructure",
            "Networking",
            "Systems Administration",
            "Database Administration (DBA)",
            "Security",
            "Software Development",
            "Help Desk ",
            "Project Management ",
            "Data Analytics",
            "Cloud Computing"});
            this.CBDivision.Location = new System.Drawing.Point(296, 292);
            this.CBDivision.Name = "CBDivision";
            this.CBDivision.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBDivision.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBDivision.Radius = 5;
            this.CBDivision.Size = new System.Drawing.Size(218, 37);
            this.CBDivision.TabIndex = 33;
            // 
            // TicketEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 653);
            this.Controls.Add(this.CBDivision);
            this.Controls.Add(this.CBCreator);
            this.Controls.Add(this.BTNDueDate);
            this.Controls.Add(this.BTNStartDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.TBDueDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBStartDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBTaskStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBPriority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBAssignTo);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketEditorView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox TBTitle;
        private Guna.UI.WinForms.GunaComboBox CBAssignTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox CBPriority;
        private Guna.UI.WinForms.GunaTextBox TBDescription;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox CBTaskStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox TBStartDate;
        private Guna.UI.WinForms.GunaTextBox TBDueDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton BTNSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaButton BTNStartDate;
        private Guna.UI.WinForms.GunaButton BTNDueDate;
        private Guna.UI.WinForms.GunaComboBox CBCreator;
        private Guna.UI.WinForms.GunaComboBox CBDivision;
    }
}