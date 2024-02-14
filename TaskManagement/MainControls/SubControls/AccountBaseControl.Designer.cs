namespace TaskManagement.MainControls.SubControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeDetailsContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.EmployeeDetailsPanel = new System.Windows.Forms.Panel();
            this.CBRole = new Guna.UI.WinForms.GunaComboBox();
            this.BTNSubmit = new Guna.UI.WinForms.GunaButton();
            this.TBPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBFirstname = new Guna.UI.WinForms.GunaTextBox();
            this.CBGender = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBLastname = new Guna.UI.WinForms.GunaTextBox();
            this.TBEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBPosition = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.DGVUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNDelete = new Guna.UI.WinForms.GunaButton();
            this.BTNClear = new Guna.UI.WinForms.GunaButton();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEditorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeDetailsContainer.SuspendLayout();
            this.EmployeeDetailsPanel.SuspendLayout();
            this.GridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDetailsContainer
            // 
            this.EmployeeDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeDetailsContainer.BaseColor = System.Drawing.Color.White;
            this.EmployeeDetailsContainer.Controls.Add(this.EmployeeDetailsPanel);
            this.EmployeeDetailsContainer.Location = new System.Drawing.Point(36, 126);
            this.EmployeeDetailsContainer.Name = "EmployeeDetailsContainer";
            this.EmployeeDetailsContainer.ShadowColor = System.Drawing.Color.Silver;
            this.EmployeeDetailsContainer.ShadowShift = 3;
            this.EmployeeDetailsContainer.Size = new System.Drawing.Size(325, 509);
            this.EmployeeDetailsContainer.TabIndex = 0;
            // 
            // EmployeeDetailsPanel
            // 
            this.EmployeeDetailsPanel.Controls.Add(this.BTNClear);
            this.EmployeeDetailsPanel.Controls.Add(this.BTNDelete);
            this.EmployeeDetailsPanel.Controls.Add(this.CBRole);
            this.EmployeeDetailsPanel.Controls.Add(this.BTNSubmit);
            this.EmployeeDetailsPanel.Controls.Add(this.TBPassword);
            this.EmployeeDetailsPanel.Controls.Add(this.label2);
            this.EmployeeDetailsPanel.Controls.Add(this.label1);
            this.EmployeeDetailsPanel.Controls.Add(this.label10);
            this.EmployeeDetailsPanel.Controls.Add(this.TBFirstname);
            this.EmployeeDetailsPanel.Controls.Add(this.CBGender);
            this.EmployeeDetailsPanel.Controls.Add(this.label4);
            this.EmployeeDetailsPanel.Controls.Add(this.label7);
            this.EmployeeDetailsPanel.Controls.Add(this.TBLastname);
            this.EmployeeDetailsPanel.Controls.Add(this.TBEmail);
            this.EmployeeDetailsPanel.Controls.Add(this.label8);
            this.EmployeeDetailsPanel.Controls.Add(this.label9);
            this.EmployeeDetailsPanel.Controls.Add(this.CBPosition);
            this.EmployeeDetailsPanel.Controls.Add(this.label6);
            this.EmployeeDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDetailsPanel.Name = "EmployeeDetailsPanel";
            this.EmployeeDetailsPanel.Size = new System.Drawing.Size(325, 509);
            this.EmployeeDetailsPanel.TabIndex = 2;
            // 
            // CBRole
            // 
            this.CBRole.BackColor = System.Drawing.Color.Transparent;
            this.CBRole.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBRole.BorderColor = System.Drawing.Color.Silver;
            this.CBRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBRole.FocusedColor = System.Drawing.Color.Empty;
            this.CBRole.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRole.ForeColor = System.Drawing.Color.Black;
            this.CBRole.FormattingEnabled = true;
            this.CBRole.ItemHeight = 29;
            this.CBRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.CBRole.Location = new System.Drawing.Point(37, 97);
            this.CBRole.Name = "CBRole";
            this.CBRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBRole.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBRole.Radius = 5;
            this.CBRole.Size = new System.Drawing.Size(114, 35);
            this.CBRole.TabIndex = 23;
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
            this.BTNSubmit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.ForeColor = System.Drawing.Color.White;
            this.BTNSubmit.Image = null;
            this.BTNSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNSubmit.Location = new System.Drawing.Point(164, 436);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.BTNSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNSubmit.OnHoverImage = null;
            this.BTNSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.BTNSubmit.Radius = 5;
            this.BTNSubmit.Size = new System.Drawing.Size(116, 42);
            this.BTNSubmit.TabIndex = 33;
            this.BTNSubmit.Text = "Submit";
            this.BTNSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.Transparent;
            this.TBPassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBPassword.BorderColor = System.Drawing.Color.Silver;
            this.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TBPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBPassword.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(36, 366);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '\0';
            this.TBPassword.Radius = 5;
            this.TBPassword.SelectedText = "";
            this.TBPassword.Size = new System.Drawing.Size(252, 36);
            this.TBPassword.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label10.Location = new System.Drawing.Point(34, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Password";
            // 
            // TBFirstname
            // 
            this.TBFirstname.BackColor = System.Drawing.Color.Transparent;
            this.TBFirstname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBFirstname.BorderColor = System.Drawing.Color.Silver;
            this.TBFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBFirstname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBFirstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBFirstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBFirstname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFirstname.Location = new System.Drawing.Point(37, 167);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.PasswordChar = '\0';
            this.TBFirstname.Radius = 5;
            this.TBFirstname.SelectedText = "";
            this.TBFirstname.Size = new System.Drawing.Size(114, 36);
            this.TBFirstname.TabIndex = 14;
            // 
            // CBGender
            // 
            this.CBGender.BackColor = System.Drawing.Color.Transparent;
            this.CBGender.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBGender.BorderColor = System.Drawing.Color.Silver;
            this.CBGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBGender.FocusedColor = System.Drawing.Color.Empty;
            this.CBGender.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGender.ForeColor = System.Drawing.Color.Black;
            this.CBGender.FormattingEnabled = true;
            this.CBGender.ItemHeight = 29;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.CBGender.Location = new System.Drawing.Point(173, 97);
            this.CBGender.Name = "CBGender";
            this.CBGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBGender.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBGender.Radius = 5;
            this.CBGender.Size = new System.Drawing.Size(115, 35);
            this.CBGender.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(169, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(170, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gender";
            // 
            // TBLastname
            // 
            this.TBLastname.BackColor = System.Drawing.Color.Transparent;
            this.TBLastname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.TBLastname.BorderColor = System.Drawing.Color.Silver;
            this.TBLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLastname.FocusedBaseColor = System.Drawing.Color.White;
            this.TBLastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBLastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBLastname.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLastname.Location = new System.Drawing.Point(173, 166);
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
            this.TBEmail.BorderColor = System.Drawing.Color.Silver;
            this.TBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.TBEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TBEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TBEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(36, 299);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.Radius = 5;
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(252, 36);
            this.TBEmail.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(34, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(34, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Email";
            // 
            // CBPosition
            // 
            this.CBPosition.BackColor = System.Drawing.Color.Transparent;
            this.CBPosition.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.CBPosition.BorderColor = System.Drawing.Color.Silver;
            this.CBPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBPosition.FocusedColor = System.Drawing.Color.Empty;
            this.CBPosition.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPosition.ForeColor = System.Drawing.Color.Black;
            this.CBPosition.FormattingEnabled = true;
            this.CBPosition.ItemHeight = 29;
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
            this.CBPosition.Location = new System.Drawing.Point(37, 236);
            this.CBPosition.Name = "CBPosition";
            this.CBPosition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.CBPosition.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.CBPosition.Radius = 5;
            this.CBPosition.Size = new System.Drawing.Size(251, 35);
            this.CBPosition.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(34, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Position";
            // 
            // GridContainer
            // 
            this.GridContainer.BackColor = System.Drawing.Color.Transparent;
            this.GridContainer.BaseColor = System.Drawing.Color.White;
            this.GridContainer.Controls.Add(this.DGVUsers);
            this.GridContainer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridContainer.Location = new System.Drawing.Point(400, 126);
            this.GridContainer.Name = "GridContainer";
            this.GridContainer.ShadowColor = System.Drawing.Color.Silver;
            this.GridContainer.ShadowShift = 3;
            this.GridContainer.Size = new System.Drawing.Size(740, 655);
            this.GridContainer.TabIndex = 1;
            // 
            // DGVUsers
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVUsers.AutoGenerateColumns = false;
            this.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsers.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVUsers.ColumnHeadersHeight = 45;
            this.DGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.DGVUsers.DataSource = this.userEditorBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUsers.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.GridColor = System.Drawing.Color.White;
            this.DGVUsers.Location = new System.Drawing.Point(0, 0);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.DGVUsers.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVUsers.RowTemplate.Height = 40;
            this.DGVUsers.RowTemplate.ReadOnly = true;
            this.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsers.Size = new System.Drawing.Size(740, 655);
            this.DGVUsers.TabIndex = 1;
            this.DGVUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.DGVUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.DGVUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUsers.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVUsers.ThemeStyle.ReadOnly = false;
            this.DGVUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVUsers.ThemeStyle.RowsStyle.Height = 40;
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(35, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(37, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(738, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Here, you have full control over user accounts, ensuring smooth collaboration and" +
    " efficient project management";
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
            this.BTNDelete.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.Color.Red;
            this.BTNDelete.Image = null;
            this.BTNDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNDelete.Location = new System.Drawing.Point(40, 436);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BTNDelete.OnHoverBorderColor = System.Drawing.Color.Red;
            this.BTNDelete.OnHoverForeColor = System.Drawing.Color.Red;
            this.BTNDelete.OnHoverImage = null;
            this.BTNDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BTNDelete.Radius = 5;
            this.BTNDelete.Size = new System.Drawing.Size(116, 42);
            this.BTNDelete.TabIndex = 34;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNClear
            // 
            this.BTNClear.AnimationHoverSpeed = 0.07F;
            this.BTNClear.AnimationSpeed = 0.03F;
            this.BTNClear.BackColor = System.Drawing.Color.Transparent;
            this.BTNClear.BaseColor = System.Drawing.Color.White;
            this.BTNClear.BorderColor = System.Drawing.Color.Red;
            this.BTNClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNClear.FocusedColor = System.Drawing.Color.Empty;
            this.BTNClear.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClear.ForeColor = System.Drawing.Color.Red;
            this.BTNClear.Image = global::TaskManagement.Properties.Resources.reload;
            this.BTNClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClear.ImageSize = new System.Drawing.Size(20, 20);
            this.BTNClear.Location = new System.Drawing.Point(253, 28);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTNClear.OnHoverForeColor = System.Drawing.Color.White;
            this.BTNClear.OnHoverImage = null;
            this.BTNClear.OnPressedColor = System.Drawing.Color.Black;
            this.BTNClear.Radius = 5;
            this.BTNClear.Size = new System.Drawing.Size(35, 29);
            this.BTNClear.TabIndex = 35;
            this.BTNClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userEditorBindingSource
            // 
            this.userEditorBindingSource.DataSource = typeof(TaskManagement.Models.UserEditor);
            // 
            // AccountBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridContainer);
            this.Controls.Add(this.EmployeeDetailsContainer);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountBaseControl";
            this.Size = new System.Drawing.Size(1180, 825);
            this.EmployeeDetailsContainer.ResumeLayout(false);
            this.EmployeeDetailsPanel.ResumeLayout(false);
            this.EmployeeDetailsPanel.PerformLayout();
            this.GridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEditorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel EmployeeDetailsContainer;
        private Guna.UI.WinForms.GunaShadowPanel GridContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TBFirstname;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox TBLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox CBRole;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox CBPosition;
        private Guna.UI.WinForms.GunaTextBox TBPassword;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox CBGender;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox TBEmail;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton BTNSubmit;
        private Guna.UI.WinForms.GunaDataGridView DGVUsers;
        private System.Windows.Forms.BindingSource userEditorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel EmployeeDetailsPanel;
        private Guna.UI.WinForms.GunaButton BTNDelete;
        private Guna.UI.WinForms.GunaButton BTNClear;
    }
}
