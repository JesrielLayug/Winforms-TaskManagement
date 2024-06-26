﻿namespace TaskManagement.MainControls.EmployeeSubControls
{
    partial class EmployeeRequestControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNSearch = new Guna.UI.WinForms.GunaButton();
            this.TBSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.ContentContainer = new System.Windows.Forms.Panel();
            this.BTNDelete = new Guna.UI.WinForms.GunaButton();
            this.BTNUpdate = new Guna.UI.WinForms.GunaButton();
            this.TicketDetailsContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.TicketDetails = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaShadowPanel8 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBRequestCreated = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaShadowPanel7 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBStatus = new System.Windows.Forms.Label();
            this.gunaShadowPanel6 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBIssuer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaShadowPanel5 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBAssignee = new System.Windows.Forms.Label();
            this.gunaShadowPanel3 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBDivision = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBDueDate = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBPriority = new System.Windows.Forms.Label();
            this.gunaShadowPanel4 = new Guna.UI.WinForms.GunaShadowPanel();
            this.LBStartDate = new System.Windows.Forms.Label();
            this.LBDescription = new System.Windows.Forms.Label();
            this.LBTicketName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.DGVRequests = new Guna.UI.WinForms.GunaDataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRequestCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSubRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.ContentContainer.SuspendLayout();
            this.TicketDetailsContainer.SuspendLayout();
            this.TicketDetails.SuspendLayout();
            this.gunaShadowPanel8.SuspendLayout();
            this.gunaShadowPanel7.SuspendLayout();
            this.gunaShadowPanel6.SuspendLayout();
            this.gunaShadowPanel5.SuspendLayout();
            this.gunaShadowPanel3.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel4.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSubRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Controls.Add(this.TBSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 59);
            this.panel1.TabIndex = 17;
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
            this.BTNSearch.Location = new System.Drawing.Point(1086, 12);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSearch.OnHoverImage = null;
            this.BTNSearch.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSearch.Radius = 5;
            this.BTNSearch.Size = new System.Drawing.Size(75, 35);
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
            this.TBSearch.Location = new System.Drawing.Point(864, 11);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.Radius = 5;
            this.TBSearch.SelectedText = "";
            this.TBSearch.Size = new System.Drawing.Size(216, 36);
            this.TBSearch.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pending Requests";
            // 
            // MainContainer
            // 
            this.MainContainer.Controls.Add(this.ContentContainer);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 59);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1202, 622);
            this.MainContainer.TabIndex = 18;
            // 
            // ContentContainer
            // 
            this.ContentContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContentContainer.Controls.Add(this.BTNDelete);
            this.ContentContainer.Controls.Add(this.BTNUpdate);
            this.ContentContainer.Controls.Add(this.TicketDetailsContainer);
            this.ContentContainer.Controls.Add(this.Container);
            this.ContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentContainer.Location = new System.Drawing.Point(0, 0);
            this.ContentContainer.Name = "ContentContainer";
            this.ContentContainer.Size = new System.Drawing.Size(1202, 622);
            this.ContentContainer.TabIndex = 0;
            // 
            // BTNDelete
            // 
            this.BTNDelete.AnimationHoverSpeed = 0.07F;
            this.BTNDelete.AnimationSpeed = 0.03F;
            this.BTNDelete.BackColor = System.Drawing.Color.Transparent;
            this.BTNDelete.BaseColor = System.Drawing.Color.White;
            this.BTNDelete.BorderColor = System.Drawing.Color.Red;
            this.BTNDelete.BorderSize = 1;
            this.BTNDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BTNDelete.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.Color.Red;
            this.BTNDelete.Image = null;
            this.BTNDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNDelete.Location = new System.Drawing.Point(1009, 516);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BTNDelete.OnHoverBorderColor = System.Drawing.Color.Red;
            this.BTNDelete.OnHoverForeColor = System.Drawing.Color.Red;
            this.BTNDelete.OnHoverImage = null;
            this.BTNDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BTNDelete.Radius = 5;
            this.BTNDelete.Size = new System.Drawing.Size(152, 36);
            this.BTNDelete.TabIndex = 35;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.AnimationHoverSpeed = 0.07F;
            this.BTNUpdate.AnimationSpeed = 0.03F;
            this.BTNUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BTNUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BTNUpdate.BorderColor = System.Drawing.Color.Black;
            this.BTNUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.BTNUpdate.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUpdate.ForeColor = System.Drawing.Color.White;
            this.BTNUpdate.Image = null;
            this.BTNUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNUpdate.Location = new System.Drawing.Point(839, 516);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNUpdate.OnHoverImage = null;
            this.BTNUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.BTNUpdate.Radius = 5;
            this.BTNUpdate.Size = new System.Drawing.Size(155, 36);
            this.BTNUpdate.TabIndex = 34;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // TicketDetailsContainer
            // 
            this.TicketDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.TicketDetailsContainer.BaseColor = System.Drawing.Color.White;
            this.TicketDetailsContainer.Controls.Add(this.TicketDetails);
            this.TicketDetailsContainer.Location = new System.Drawing.Point(831, 19);
            this.TicketDetailsContainer.Name = "TicketDetailsContainer";
            this.TicketDetailsContainer.Radius = 5;
            this.TicketDetailsContainer.ShadowColor = System.Drawing.Color.Gainsboro;
            this.TicketDetailsContainer.ShadowShift = 12;
            this.TicketDetailsContainer.Size = new System.Drawing.Size(340, 483);
            this.TicketDetailsContainer.TabIndex = 24;
            // 
            // TicketDetails
            // 
            this.TicketDetails.Controls.Add(this.label7);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel8);
            this.TicketDetails.Controls.Add(this.label6);
            this.TicketDetails.Controls.Add(this.label4);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel7);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel6);
            this.TicketDetails.Controls.Add(this.label8);
            this.TicketDetails.Controls.Add(this.label1);
            this.TicketDetails.Controls.Add(this.label3);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel5);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel3);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel2);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel1);
            this.TicketDetails.Controls.Add(this.gunaShadowPanel4);
            this.TicketDetails.Controls.Add(this.LBDescription);
            this.TicketDetails.Controls.Add(this.LBTicketName);
            this.TicketDetails.Controls.Add(this.label5);
            this.TicketDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketDetails.Location = new System.Drawing.Point(0, 0);
            this.TicketDetails.Name = "TicketDetails";
            this.TicketDetails.Size = new System.Drawing.Size(340, 483);
            this.TicketDetails.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(57, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 63;
            this.label7.Text = "Created:";
            // 
            // gunaShadowPanel8
            // 
            this.gunaShadowPanel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel8.Controls.Add(this.LBRequestCreated);
            this.gunaShadowPanel8.Location = new System.Drawing.Point(126, 414);
            this.gunaShadowPanel8.Name = "gunaShadowPanel8";
            this.gunaShadowPanel8.Radius = 3;
            this.gunaShadowPanel8.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel8.ShadowShift = 2;
            this.gunaShadowPanel8.Size = new System.Drawing.Size(56, 30);
            this.gunaShadowPanel8.TabIndex = 62;
            // 
            // LBRequestCreated
            // 
            this.LBRequestCreated.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRequestCreated.ForeColor = System.Drawing.Color.White;
            this.LBRequestCreated.Location = new System.Drawing.Point(6, 9);
            this.LBRequestCreated.Name = "LBRequestCreated";
            this.LBRequestCreated.Size = new System.Drawing.Size(48, 14);
            this.LBRequestCreated.TabIndex = 33;
            this.LBRequestCreated.Text = "Feb 24";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(83, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 61;
            this.label6.Text = "Due:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(74, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 60;
            this.label4.Text = "Start:";
            // 
            // gunaShadowPanel7
            // 
            this.gunaShadowPanel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel7.Controls.Add(this.LBStatus);
            this.gunaShadowPanel7.Location = new System.Drawing.Point(209, 31);
            this.gunaShadowPanel7.Name = "gunaShadowPanel7";
            this.gunaShadowPanel7.Radius = 3;
            this.gunaShadowPanel7.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel7.ShadowShift = 2;
            this.gunaShadowPanel7.Size = new System.Drawing.Size(97, 36);
            this.gunaShadowPanel7.TabIndex = 51;
            // 
            // LBStatus
            // 
            this.LBStatus.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStatus.ForeColor = System.Drawing.Color.White;
            this.LBStatus.Location = new System.Drawing.Point(6, 4);
            this.LBStatus.Name = "LBStatus";
            this.LBStatus.Size = new System.Drawing.Size(83, 28);
            this.LBStatus.TabIndex = 34;
            this.LBStatus.Text = "Completed";
            this.LBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaShadowPanel6
            // 
            this.gunaShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel6.Controls.Add(this.LBIssuer);
            this.gunaShadowPanel6.Location = new System.Drawing.Point(126, 302);
            this.gunaShadowPanel6.Name = "gunaShadowPanel6";
            this.gunaShadowPanel6.Radius = 3;
            this.gunaShadowPanel6.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel6.ShadowShift = 2;
            this.gunaShadowPanel6.Size = new System.Drawing.Size(155, 30);
            this.gunaShadowPanel6.TabIndex = 56;
            // 
            // LBIssuer
            // 
            this.LBIssuer.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIssuer.ForeColor = System.Drawing.Color.White;
            this.LBIssuer.Location = new System.Drawing.Point(14, 9);
            this.LBIssuer.Name = "LBIssuer";
            this.LBIssuer.Size = new System.Drawing.Size(117, 14);
            this.LBIssuer.TabIndex = 37;
            this.LBIssuer.Text = "Jesriel Layug";
            this.LBIssuer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(58, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "Division:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(50, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 58;
            this.label1.Text = "Assignee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(71, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 57;
            this.label3.Text = "Level:";
            // 
            // gunaShadowPanel5
            // 
            this.gunaShadowPanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel5.Controls.Add(this.LBAssignee);
            this.gunaShadowPanel5.Location = new System.Drawing.Point(126, 230);
            this.gunaShadowPanel5.Name = "gunaShadowPanel5";
            this.gunaShadowPanel5.Radius = 3;
            this.gunaShadowPanel5.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel5.ShadowShift = 2;
            this.gunaShadowPanel5.Size = new System.Drawing.Size(155, 30);
            this.gunaShadowPanel5.TabIndex = 55;
            // 
            // LBAssignee
            // 
            this.LBAssignee.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAssignee.ForeColor = System.Drawing.Color.White;
            this.LBAssignee.Location = new System.Drawing.Point(14, 9);
            this.LBAssignee.Name = "LBAssignee";
            this.LBAssignee.Size = new System.Drawing.Size(117, 14);
            this.LBAssignee.TabIndex = 37;
            this.LBAssignee.Text = "Jesriel Layug";
            this.LBAssignee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaShadowPanel3
            // 
            this.gunaShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel3.Controls.Add(this.LBDivision);
            this.gunaShadowPanel3.Location = new System.Drawing.Point(126, 266);
            this.gunaShadowPanel3.Name = "gunaShadowPanel3";
            this.gunaShadowPanel3.Radius = 3;
            this.gunaShadowPanel3.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel3.ShadowShift = 2;
            this.gunaShadowPanel3.Size = new System.Drawing.Size(186, 30);
            this.gunaShadowPanel3.TabIndex = 52;
            // 
            // LBDivision
            // 
            this.LBDivision.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDivision.ForeColor = System.Drawing.Color.White;
            this.LBDivision.Location = new System.Drawing.Point(7, 9);
            this.LBDivision.Name = "LBDivision";
            this.LBDivision.Size = new System.Drawing.Size(171, 14);
            this.LBDivision.TabIndex = 36;
            this.LBDivision.Text = "Systems Administration";
            this.LBDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel2.Controls.Add(this.LBDueDate);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(126, 378);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 3;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel2.ShadowShift = 2;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(56, 30);
            this.gunaShadowPanel2.TabIndex = 53;
            // 
            // LBDueDate
            // 
            this.LBDueDate.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDueDate.ForeColor = System.Drawing.Color.White;
            this.LBDueDate.Location = new System.Drawing.Point(6, 9);
            this.LBDueDate.Name = "LBDueDate";
            this.LBDueDate.Size = new System.Drawing.Size(48, 14);
            this.LBDueDate.TabIndex = 33;
            this.LBDueDate.Text = "Feb 24";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel1.Controls.Add(this.LBPriority);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(126, 194);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 3;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.ShadowShift = 2;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(119, 30);
            this.gunaShadowPanel1.TabIndex = 54;
            // 
            // LBPriority
            // 
            this.LBPriority.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPriority.ForeColor = System.Drawing.Color.White;
            this.LBPriority.Location = new System.Drawing.Point(10, 9);
            this.LBPriority.Name = "LBPriority";
            this.LBPriority.Size = new System.Drawing.Size(103, 14);
            this.LBPriority.TabIndex = 32;
            this.LBPriority.Text = "Medium Priority";
            this.LBPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaShadowPanel4
            // 
            this.gunaShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.gunaShadowPanel4.Controls.Add(this.LBStartDate);
            this.gunaShadowPanel4.Location = new System.Drawing.Point(126, 342);
            this.gunaShadowPanel4.Name = "gunaShadowPanel4";
            this.gunaShadowPanel4.Radius = 3;
            this.gunaShadowPanel4.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel4.ShadowShift = 2;
            this.gunaShadowPanel4.Size = new System.Drawing.Size(56, 30);
            this.gunaShadowPanel4.TabIndex = 50;
            // 
            // LBStartDate
            // 
            this.LBStartDate.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStartDate.ForeColor = System.Drawing.Color.White;
            this.LBStartDate.Location = new System.Drawing.Point(5, 8);
            this.LBStartDate.Name = "LBStartDate";
            this.LBStartDate.Size = new System.Drawing.Size(48, 14);
            this.LBStartDate.TabIndex = 34;
            this.LBStartDate.Text = "Feb 24";
            // 
            // LBDescription
            // 
            this.LBDescription.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.LBDescription.Location = new System.Drawing.Point(42, 84);
            this.LBDescription.Name = "LBDescription";
            this.LBDescription.Size = new System.Drawing.Size(269, 85);
            this.LBDescription.TabIndex = 49;
            this.LBDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            this.LBDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBTicketName
            // 
            this.LBTicketName.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTicketName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.LBTicketName.Location = new System.Drawing.Point(29, 22);
            this.LBTicketName.Name = "LBTicketName";
            this.LBTicketName.Size = new System.Drawing.Size(174, 53);
            this.LBTicketName.TabIndex = 48;
            this.LBTicketName.Text = "Lorem Ipsum";
            this.LBTicketName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(66, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "Issuer:";
            // 
            // Container
            // 
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.Controls.Add(this.DGVRequests);
            this.Container.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Container.Location = new System.Drawing.Point(31, 36);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(781, 516);
            this.Container.TabIndex = 23;
            // 
            // DGVRequests
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRequests.AutoGenerateColumns = false;
            this.DGVRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRequests.BackgroundColor = System.Drawing.Color.White;
            this.DGVRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRequests.ColumnHeadersHeight = 45;
            this.DGVRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.assignNameDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.ticketStatusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateRequestCreatedDataGridViewTextBoxColumn});
            this.DGVRequests.DataSource = this.employeeSubRequestBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRequests.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRequests.EnableHeadersVisualStyles = false;
            this.DGVRequests.GridColor = System.Drawing.Color.White;
            this.DGVRequests.Location = new System.Drawing.Point(0, 0);
            this.DGVRequests.Name = "DGVRequests";
            this.DGVRequests.ReadOnly = true;
            this.DGVRequests.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DGVRequests.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVRequests.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVRequests.RowTemplate.Height = 40;
            this.DGVRequests.RowTemplate.ReadOnly = true;
            this.DGVRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRequests.Size = new System.Drawing.Size(779, 514);
            this.DGVRequests.TabIndex = 2;
            this.DGVRequests.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVRequests.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVRequests.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVRequests.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DGVRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.DGVRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVRequests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRequests.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVRequests.ThemeStyle.ReadOnly = true;
            this.DGVRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRequests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVRequests.ThemeStyle.RowsStyle.Height = 40;
            this.DGVRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignNameDataGridViewTextBoxColumn
            // 
            this.assignNameDataGridViewTextBoxColumn.DataPropertyName = "AssignName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.assignNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.assignNameDataGridViewTextBoxColumn.HeaderText = "Assignee Name";
            this.assignNameDataGridViewTextBoxColumn.Name = "assignNameDataGridViewTextBoxColumn";
            this.assignNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketStatusDataGridViewTextBoxColumn
            // 
            this.ticketStatusDataGridViewTextBoxColumn.DataPropertyName = "TicketStatus";
            this.ticketStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.ticketStatusDataGridViewTextBoxColumn.Name = "ticketStatusDataGridViewTextBoxColumn";
            this.ticketStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRequestCreatedDataGridViewTextBoxColumn
            // 
            this.dateRequestCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateRequestCreated";
            this.dateRequestCreatedDataGridViewTextBoxColumn.HeaderText = "Request Created";
            this.dateRequestCreatedDataGridViewTextBoxColumn.Name = "dateRequestCreatedDataGridViewTextBoxColumn";
            this.dateRequestCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeSubRequestBindingSource
            // 
            this.employeeSubRequestBindingSource.DataSource = typeof(TaskManagement.Models.EmployeeTicketInfo);
            // 
            // EmployeeRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeRequestControl";
            this.Size = new System.Drawing.Size(1202, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.ContentContainer.ResumeLayout(false);
            this.TicketDetailsContainer.ResumeLayout(false);
            this.TicketDetails.ResumeLayout(false);
            this.TicketDetails.PerformLayout();
            this.gunaShadowPanel8.ResumeLayout(false);
            this.gunaShadowPanel7.ResumeLayout(false);
            this.gunaShadowPanel6.ResumeLayout(false);
            this.gunaShadowPanel5.ResumeLayout(false);
            this.gunaShadowPanel3.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel4.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSubRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource employeeSubRequestBindingSource;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel ContentContainer;
        private Guna.UI.WinForms.GunaShadowPanel TicketDetailsContainer;
        private System.Windows.Forms.Panel TicketDetails;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel8;
        private System.Windows.Forms.Label LBRequestCreated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel7;
        private System.Windows.Forms.Label LBStatus;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel6;
        private System.Windows.Forms.Label LBIssuer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel5;
        private System.Windows.Forms.Label LBAssignee;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel3;
        private System.Windows.Forms.Label LBDivision;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Label LBDueDate;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label LBPriority;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel4;
        private System.Windows.Forms.Label LBStartDate;
        private System.Windows.Forms.Label LBDescription;
        private System.Windows.Forms.Label LBTicketName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Container;
        private Guna.UI.WinForms.GunaDataGridView DGVRequests;
        private Guna.UI.WinForms.GunaButton BTNUpdate;
        private Guna.UI.WinForms.GunaButton BTNDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRequestCreatedDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton BTNSearch;
        private Guna.UI.WinForms.GunaTextBox TBSearch;
    }
}
