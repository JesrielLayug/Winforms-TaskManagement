namespace TaskManagement.MainControls.GlobalComponents
{
    partial class LogsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GridContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.DGVLogs = new Guna.UI.WinForms.GunaDataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogsEditorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNSearch = new Guna.UI.WinForms.GunaButton();
            this.TBSearch = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.GridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogsEditorBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Logs";
            // 
            // GridContainer
            // 
            this.GridContainer.BackColor = System.Drawing.Color.Transparent;
            this.GridContainer.BaseColor = System.Drawing.Color.White;
            this.GridContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridContainer.Controls.Add(this.DGVLogs);
            this.GridContainer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridContainer.Location = new System.Drawing.Point(27, 87);
            this.GridContainer.Name = "GridContainer";
            this.GridContainer.ShadowColor = System.Drawing.Color.Gainsboro;
            this.GridContainer.ShadowShift = 0;
            this.GridContainer.Size = new System.Drawing.Size(945, 565);
            this.GridContainer.TabIndex = 13;
            // 
            // DGVLogs
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVLogs.AutoGenerateColumns = false;
            this.DGVLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLogs.BackgroundColor = System.Drawing.Color.White;
            this.DGVLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVLogs.ColumnHeadersHeight = 45;
            this.DGVLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.DGVLogs.DataSource = this.userLogsEditorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLogs.EnableHeadersVisualStyles = false;
            this.DGVLogs.GridColor = System.Drawing.Color.White;
            this.DGVLogs.Location = new System.Drawing.Point(0, 0);
            this.DGVLogs.Name = "DGVLogs";
            this.DGVLogs.ReadOnly = true;
            this.DGVLogs.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLogs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVLogs.RowTemplate.Height = 40;
            this.DGVLogs.RowTemplate.ReadOnly = true;
            this.DGVLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLogs.Size = new System.Drawing.Size(943, 563);
            this.DGVLogs.TabIndex = 1;
            this.DGVLogs.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVLogs.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVLogs.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DGVLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.DGVLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVLogs.ThemeStyle.HeaderStyle.Height = 45;
            this.DGVLogs.ThemeStyle.ReadOnly = true;
            this.DGVLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVLogs.ThemeStyle.RowsStyle.Height = 40;
            this.DGVLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 61.27178F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 3;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.FillWeight = 68.52792F;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.FillWeight = 170.2003F;
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLogsEditorBindingSource
            // 
            this.userLogsEditorBindingSource.DataSource = typeof(TaskManagement.Models.UserLogsEditor);
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
            this.BTNSearch.Location = new System.Drawing.Point(1087, 12);
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
            this.TBSearch.Location = new System.Drawing.Point(865, 11);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.Radius = 5;
            this.TBSearch.SelectedText = "";
            this.TBSearch.Size = new System.Drawing.Size(216, 36);
            this.TBSearch.TabIndex = 40;
            // 
            // LogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.GridContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogsControl";
            this.Size = new System.Drawing.Size(1202, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogsEditorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaShadowPanel GridContainer;
        private Guna.UI.WinForms.GunaDataGridView DGVLogs;
        private System.Windows.Forms.BindingSource userLogsEditorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton BTNSearch;
        private Guna.UI.WinForms.GunaTextBox TBSearch;
    }
}
