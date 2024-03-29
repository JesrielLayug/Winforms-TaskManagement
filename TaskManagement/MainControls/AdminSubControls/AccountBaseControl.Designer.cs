﻿namespace TaskManagement.MainControls.SubControls
{
    partial class AccountBaseControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeDetailsContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.EmployeeDetailsPanel = new System.Windows.Forms.Panel();
            this.CBAuthorization = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNClear = new Guna.UI.WinForms.GunaButton();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.CBGender = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBFirstname = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBLastname = new Guna.UI.WinForms.GunaTextBox();
            this.TBEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBPosition = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.DGVUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authorization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEditorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNRegister = new Guna.UI.WinForms.GunaButton();
            this.BTNSearch = new Guna.UI.WinForms.GunaButton();
            this.TBSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeDetailsContainer.SuspendLayout();
            this.EmployeeDetailsPanel.SuspendLayout();
            this.GridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDetailsContainer
            // 
            this.EmployeeDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeDetailsContainer.BaseColor = System.Drawing.Color.White;
            this.EmployeeDetailsContainer.Controls.Add(this.EmployeeDetailsPanel);
            this.EmployeeDetailsContainer.Location = new System.Drawing.Point(44, 133);
            this.EmployeeDetailsContainer.Name = "EmployeeDetailsContainer";
            this.EmployeeDetailsContainer.Radius = 5;
            this.EmployeeDetailsContainer.ShadowColor = System.Drawing.Color.Gainsboro;
            this.EmployeeDetailsContainer.ShadowShift = 12;
            this.EmployeeDetailsContainer.Size = new System.Drawing.Size(327, 433);
            this.EmployeeDetailsContainer.TabIndex = 0;
            // 
            // EmployeeDetailsPanel
            // 
            this.EmployeeDetailsPanel.Controls.Add(this.CBAuthorization);
            this.EmployeeDetailsPanel.Controls.Add(this.label5);
            this.EmployeeDetailsPanel.Controls.Add(this.BTNClear);
            this.EmployeeDetailsPanel.Controls.Add(this.BTNSubmit);
            this.EmployeeDetailsPanel.Controls.Add(this.CBGender);
            this.EmployeeDetailsPanel.Controls.Add(this.label7);
            this.EmployeeDetailsPanel.Controls.Add(this.label2);
            this.EmployeeDetailsPanel.Controls.Add(this.TBFirstname);
            this.EmployeeDetailsPanel.Controls.Add(this.label4);
            this.EmployeeDetailsPanel.Controls.Add(this.TBLastname);
            this.EmployeeDetailsPanel.Controls.Add(this.TBEmail);
            this.EmployeeDetailsPanel.Controls.Add(this.label9);
            this.EmployeeDetailsPanel.Controls.Add(this.CBPosition);
            this.EmployeeDetailsPanel.Controls.Add(this.label6);
            this.EmployeeDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDetailsPanel.Name = "EmployeeDetailsPanel";
            this.EmployeeDetailsPanel.Size = new System.Drawing.Size(327, 433);
            this.EmployeeDetailsPanel.TabIndex = 2;
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
            this.CBAuthorization.Location = new System.Drawing.Point(40, 56);
            this.CBAuthorization.Name = "CBAuthorization";
            this.CBAuthorization.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBAuthorization.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBAuthorization.Radius = 5;
            this.CBAuthorization.Size = new System.Drawing.Size(243, 33);
            this.CBAuthorization.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(37, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 37;
            this.label5.Text = "Authorization";
            // 
            // BTNClear
            // 
            this.BTNClear.AnimationHoverSpeed = 0.07F;
            this.BTNClear.AnimationSpeed = 0.03F;
            this.BTNClear.BackColor = System.Drawing.Color.Transparent;
            this.BTNClear.BaseColor = System.Drawing.Color.White;
            this.BTNClear.BorderColor = System.Drawing.Color.Red;
            this.BTNClear.BorderSize = 1;
            this.BTNClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNClear.FocusedColor = System.Drawing.Color.Empty;
            this.BTNClear.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClear.ForeColor = System.Drawing.Color.Red;
            this.BTNClear.Image = null;
            this.BTNClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClear.ImageSize = new System.Drawing.Size(15, 15);
            this.BTNClear.Location = new System.Drawing.Point(38, 346);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNClear.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNClear.OnHoverImage = null;
            this.BTNClear.OnPressedColor = System.Drawing.Color.Black;
            this.BTNClear.Radius = 5;
            this.BTNClear.Size = new System.Drawing.Size(115, 36);
            this.BTNClear.TabIndex = 35;
            this.BTNClear.Text = "Clear";
            this.BTNClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
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
            this.BTNSubmit.Location = new System.Drawing.Point(165, 346);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 5;
            this.BTNSubmit.Size = new System.Drawing.Size(118, 36);
            this.BTNSubmit.TabIndex = 33;
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
            this.CBGender.Location = new System.Drawing.Point(38, 170);
            this.CBGender.Name = "CBGender";
            this.CBGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBGender.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBGender.Radius = 5;
            this.CBGender.Size = new System.Drawing.Size(245, 33);
            this.CBGender.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(38, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Firstname";
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
            this.TBFirstname.Location = new System.Drawing.Point(39, 113);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.PasswordChar = '\0';
            this.TBFirstname.Radius = 5;
            this.TBFirstname.SelectedText = "";
            this.TBFirstname.Size = new System.Drawing.Size(114, 36);
            this.TBFirstname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(166, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 17;
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
            this.TBLastname.Location = new System.Drawing.Point(168, 113);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.PasswordChar = '\0';
            this.TBLastname.Radius = 5;
            this.TBLastname.SelectedText = "";
            this.TBLastname.Size = new System.Drawing.Size(115, 36);
            this.TBLastname.TabIndex = 16;
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
            this.TBEmail.Location = new System.Drawing.Point(38, 281);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.Radius = 5;
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(245, 36);
            this.TBEmail.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(37, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 30;
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
            this.CBPosition.Location = new System.Drawing.Point(39, 224);
            this.CBPosition.Name = "CBPosition";
            this.CBPosition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBPosition.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBPosition.Radius = 5;
            this.CBPosition.Size = new System.Drawing.Size(244, 33);
            this.CBPosition.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(36, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Details";
            // 
            // GridContainer
            // 
            this.GridContainer.BackColor = System.Drawing.Color.Transparent;
            this.GridContainer.BaseColor = System.Drawing.Color.White;
            this.GridContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridContainer.Controls.Add(this.DGVUsers);
            this.GridContainer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridContainer.Location = new System.Drawing.Point(407, 96);
            this.GridContainer.Name = "GridContainer";
            this.GridContainer.ShadowColor = System.Drawing.Color.Gainsboro;
            this.GridContainer.ShadowShift = 0;
            this.GridContainer.Size = new System.Drawing.Size(751, 492);
            this.GridContainer.TabIndex = 1;
            // 
            // DGVUsers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUsers.AutoGenerateColumns = false;
            this.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsers.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUsers.ColumnHeadersHeight = 45;
            this.DGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleDataGridViewTextBoxColumn,
            this.Authorization,
            this.fullNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DGVUsers.DataSource = this.userEditorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.GridColor = System.Drawing.Color.White;
            this.DGVUsers.Location = new System.Drawing.Point(0, 0);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.ReadOnly = true;
            this.DGVUsers.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.DGVUsers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVUsers.RowTemplate.Height = 40;
            this.DGVUsers.RowTemplate.ReadOnly = true;
            this.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsers.Size = new System.Drawing.Size(749, 490);
            this.DGVUsers.TabIndex = 1;
            this.DGVUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.DGVUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUsers.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVUsers.ThemeStyle.ReadOnly = true;
            this.DGVUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.RowsStyle.Height = 40;
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellContentClick);
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Authorization
            // 
            this.Authorization.DataPropertyName = "Authorization";
            this.Authorization.HeaderText = "Authorization";
            this.Authorization.Name = "Authorization";
            this.Authorization.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userEditorBindingSource
            // 
            this.userEditorBindingSource.DataSource = typeof(TaskManagement.Models.UserEditor);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BTNRegister);
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Controls.Add(this.TBSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 59);
            this.panel1.TabIndex = 15;
            // 
            // BTNRegister
            // 
            this.BTNRegister.AnimationHoverSpeed = 0.07F;
            this.BTNRegister.AnimationSpeed = 0.03F;
            this.BTNRegister.BackColor = System.Drawing.Color.Transparent;
            this.BTNRegister.BaseColor = System.Drawing.Color.Transparent;
            this.BTNRegister.BorderColor = System.Drawing.Color.White;
            this.BTNRegister.BorderSize = 1;
            this.BTNRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNRegister.FocusedColor = System.Drawing.Color.Empty;
            this.BTNRegister.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegister.ForeColor = System.Drawing.Color.White;
            this.BTNRegister.Image = null;
            this.BTNRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNRegister.Location = new System.Drawing.Point(1049, 12);
            this.BTNRegister.Name = "BTNRegister";
            this.BTNRegister.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BTNRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNRegister.OnHoverImage = null;
            this.BTNRegister.OnPressedColor = System.Drawing.Color.Black;
            this.BTNRegister.Radius = 5;
            this.BTNRegister.Size = new System.Drawing.Size(108, 36);
            this.BTNRegister.TabIndex = 40;
            this.BTNRegister.Text = "Register";
            this.BTNRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNRegister.Click += new System.EventHandler(this.BTNRegister_Click);
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
            this.BTNSearch.Location = new System.Drawing.Point(691, 13);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSearch.OnHoverImage = null;
            this.BTNSearch.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSearch.Radius = 5;
            this.BTNSearch.Size = new System.Drawing.Size(75, 35);
            this.BTNSearch.TabIndex = 38;
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
            this.TBSearch.Location = new System.Drawing.Point(469, 12);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.Radius = 5;
            this.TBSearch.SelectedText = "";
            this.TBSearch.Size = new System.Drawing.Size(216, 36);
            this.TBSearch.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Manager";
            // 
            // AccountBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridContainer);
            this.Controls.Add(this.EmployeeDetailsContainer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountBaseControl";
            this.Size = new System.Drawing.Size(1205, 623);
            this.EmployeeDetailsContainer.ResumeLayout(false);
            this.EmployeeDetailsPanel.ResumeLayout(false);
            this.EmployeeDetailsPanel.PerformLayout();
            this.GridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel EmployeeDetailsContainer;
        private Guna.UI.WinForms.GunaShadowPanel GridContainer;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TBFirstname;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox TBLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox CBPosition;
        private Guna.UI.WinForms.GunaComboBox CBGender;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox TBEmail;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton BTNSubmit;
        private Guna.UI.WinForms.GunaDataGridView DGVUsers;
        private System.Windows.Forms.BindingSource userEditorBindingSource;
        private System.Windows.Forms.Panel EmployeeDetailsPanel;
        private Guna.UI.WinForms.GunaButton BTNClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox CBAuthorization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authorization;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton BTNRegister;
        private Guna.UI.WinForms.GunaButton BTNSearch;
        private Guna.UI.WinForms.GunaTextBox TBSearch;
    }
}
