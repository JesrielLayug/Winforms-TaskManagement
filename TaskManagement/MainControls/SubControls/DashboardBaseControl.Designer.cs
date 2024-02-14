using LiveCharts.WinForms;

namespace TaskManagement.MainControls.SubControls
{
    partial class DashboardBaseControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.seconChartContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label11 = new System.Windows.Forms.Label();
            this.firstChartContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeesContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton4 = new Guna.UI.WinForms.GunaCircleButton();
            this.LBEmployeesQuantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CompletedContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton3 = new Guna.UI.WinForms.GunaCircleButton();
            this.LBCompletedQuantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InProgressContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.LBInProgressQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NexUpContainer = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.LBNextUpQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.MainContainer.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.seconChartContainer.SuspendLayout();
            this.firstChartContainer.SuspendLayout();
            this.EmployeesContainer.SuspendLayout();
            this.CompletedContainer.SuspendLayout();
            this.InProgressContainer.SuspendLayout();
            this.NexUpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dashboard";
            // 
            // MainContainer
            // 
            this.MainContainer.AutoScroll = true;
            this.MainContainer.Controls.Add(this.gunaShadowPanel2);
            this.MainContainer.Controls.Add(this.gunaShadowPanel1);
            this.MainContainer.Controls.Add(this.seconChartContainer);
            this.MainContainer.Controls.Add(this.firstChartContainer);
            this.MainContainer.Controls.Add(this.EmployeesContainer);
            this.MainContainer.Controls.Add(this.CompletedContainer);
            this.MainContainer.Controls.Add(this.InProgressContainer);
            this.MainContainer.Controls.Add(this.NexUpContainer);
            this.MainContainer.Location = new System.Drawing.Point(0, 72);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MainContainer.Size = new System.Drawing.Size(1201, 724);
            this.MainContainer.TabIndex = 9;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.cartesianChart2);
            this.gunaShadowPanel2.Controls.Add(this.label13);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(445, 584);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 7;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel2.ShadowShift = 4;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(700, 325);
            this.gunaShadowPanel2.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(34, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Division Task Analytics";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.chart1);
            this.gunaShadowPanel1.Controls.Add(this.label12);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(37, 585);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 7;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.ShadowShift = 4;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(388, 325);
            this.gunaShadowPanel1.TabIndex = 15;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(19, 61);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(346, 242);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(26, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Priority Analytics";
            // 
            // seconChartContainer
            // 
            this.seconChartContainer.BackColor = System.Drawing.Color.Transparent;
            this.seconChartContainer.BaseColor = System.Drawing.Color.White;
            this.seconChartContainer.Controls.Add(this.pieChart1);
            this.seconChartContainer.Controls.Add(this.label11);
            this.seconChartContainer.Location = new System.Drawing.Point(879, 140);
            this.seconChartContainer.Name = "seconChartContainer";
            this.seconChartContainer.Radius = 7;
            this.seconChartContainer.ShadowColor = System.Drawing.Color.Silver;
            this.seconChartContainer.ShadowShift = 4;
            this.seconChartContainer.Size = new System.Drawing.Size(266, 428);
            this.seconChartContainer.TabIndex = 13;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(25, 62);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(219, 325);
            this.pieChart1.TabIndex = 15;
            this.pieChart1.Text = "pieChart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(69, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Completed Tasks";
            // 
            // firstChartContainer
            // 
            this.firstChartContainer.BackColor = System.Drawing.Color.Transparent;
            this.firstChartContainer.BaseColor = System.Drawing.Color.White;
            this.firstChartContainer.Controls.Add(this.cartesianChart1);
            this.firstChartContainer.Controls.Add(this.label10);
            this.firstChartContainer.Location = new System.Drawing.Point(37, 140);
            this.firstChartContainer.Name = "firstChartContainer";
            this.firstChartContainer.Radius = 7;
            this.firstChartContainer.ShadowColor = System.Drawing.Color.Silver;
            this.firstChartContainer.ShadowShift = 4;
            this.firstChartContainer.Size = new System.Drawing.Size(827, 428);
            this.firstChartContainer.TabIndex = 13;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(30, 81);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(761, 306);
            this.cartesianChart1.TabIndex = 14;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Daily Created Task Analytics";
            // 
            // EmployeesContainer
            // 
            this.EmployeesContainer.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesContainer.BaseColor = System.Drawing.Color.White;
            this.EmployeesContainer.Controls.Add(this.gunaCircleButton4);
            this.EmployeesContainer.Controls.Add(this.LBEmployeesQuantity);
            this.EmployeesContainer.Controls.Add(this.label9);
            this.EmployeesContainer.Location = new System.Drawing.Point(879, 23);
            this.EmployeesContainer.Name = "EmployeesContainer";
            this.EmployeesContainer.Radius = 7;
            this.EmployeesContainer.ShadowColor = System.Drawing.Color.Silver;
            this.EmployeesContainer.ShadowShift = 4;
            this.EmployeesContainer.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.EmployeesContainer.Size = new System.Drawing.Size(266, 97);
            this.EmployeesContainer.TabIndex = 2;
            // 
            // gunaCircleButton4
            // 
            this.gunaCircleButton4.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton4.AnimationSpeed = 0.03F;
            this.gunaCircleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaCircleButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.gunaCircleButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton4.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.Image = global::TaskManagement.Properties.Resources.multiple_users_silhouette;
            this.gunaCircleButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaCircleButton4.Location = new System.Drawing.Point(180, 24);
            this.gunaCircleButton4.Name = "gunaCircleButton4";
            this.gunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.gunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.OnHoverImage = null;
            this.gunaCircleButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.Size = new System.Drawing.Size(50, 48);
            this.gunaCircleButton4.TabIndex = 16;
            // 
            // LBEmployeesQuantity
            // 
            this.LBEmployeesQuantity.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEmployeesQuantity.ForeColor = System.Drawing.Color.Black;
            this.LBEmployeesQuantity.Location = new System.Drawing.Point(29, 17);
            this.LBEmployeesQuantity.Name = "LBEmployeesQuantity";
            this.LBEmployeesQuantity.Size = new System.Drawing.Size(46, 46);
            this.LBEmployeesQuantity.TabIndex = 17;
            this.LBEmployeesQuantity.Text = "10";
            this.LBEmployeesQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Employees";
            // 
            // CompletedContainer
            // 
            this.CompletedContainer.BackColor = System.Drawing.Color.Transparent;
            this.CompletedContainer.BaseColor = System.Drawing.Color.White;
            this.CompletedContainer.Controls.Add(this.gunaCircleButton3);
            this.CompletedContainer.Controls.Add(this.LBCompletedQuantity);
            this.CompletedContainer.Controls.Add(this.label7);
            this.CompletedContainer.Location = new System.Drawing.Point(597, 23);
            this.CompletedContainer.Name = "CompletedContainer";
            this.CompletedContainer.Radius = 7;
            this.CompletedContainer.ShadowColor = System.Drawing.Color.Silver;
            this.CompletedContainer.ShadowShift = 4;
            this.CompletedContainer.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.CompletedContainer.Size = new System.Drawing.Size(266, 97);
            this.CompletedContainer.TabIndex = 2;
            // 
            // gunaCircleButton3
            // 
            this.gunaCircleButton3.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton3.AnimationSpeed = 0.03F;
            this.gunaCircleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaCircleButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.gunaCircleButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton3.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton3.Image = global::TaskManagement.Properties.Resources.check_green;
            this.gunaCircleButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaCircleButton3.Location = new System.Drawing.Point(181, 24);
            this.gunaCircleButton3.Name = "gunaCircleButton3";
            this.gunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.gunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton3.OnHoverImage = null;
            this.gunaCircleButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton3.Size = new System.Drawing.Size(50, 48);
            this.gunaCircleButton3.TabIndex = 14;
            // 
            // LBCompletedQuantity
            // 
            this.LBCompletedQuantity.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCompletedQuantity.ForeColor = System.Drawing.Color.Black;
            this.LBCompletedQuantity.Location = new System.Drawing.Point(30, 17);
            this.LBCompletedQuantity.Name = "LBCompletedQuantity";
            this.LBCompletedQuantity.Size = new System.Drawing.Size(46, 46);
            this.LBCompletedQuantity.TabIndex = 15;
            this.LBCompletedQuantity.Text = "10";
            this.LBCompletedQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Completed";
            // 
            // InProgressContainer
            // 
            this.InProgressContainer.BackColor = System.Drawing.Color.Transparent;
            this.InProgressContainer.BaseColor = System.Drawing.Color.White;
            this.InProgressContainer.Controls.Add(this.gunaCircleButton2);
            this.InProgressContainer.Controls.Add(this.LBInProgressQuantity);
            this.InProgressContainer.Controls.Add(this.label5);
            this.InProgressContainer.Location = new System.Drawing.Point(315, 23);
            this.InProgressContainer.Name = "InProgressContainer";
            this.InProgressContainer.Radius = 7;
            this.InProgressContainer.ShadowColor = System.Drawing.Color.Silver;
            this.InProgressContainer.ShadowShift = 4;
            this.InProgressContainer.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.InProgressContainer.Size = new System.Drawing.Size(266, 97);
            this.InProgressContainer.TabIndex = 2;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(194)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = global::TaskManagement.Properties.Resources.configuration;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton2.Location = new System.Drawing.Point(183, 24);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(194)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(50, 48);
            this.gunaCircleButton2.TabIndex = 13;
            // 
            // LBInProgressQuantity
            // 
            this.LBInProgressQuantity.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBInProgressQuantity.ForeColor = System.Drawing.Color.Black;
            this.LBInProgressQuantity.Location = new System.Drawing.Point(27, 17);
            this.LBInProgressQuantity.Name = "LBInProgressQuantity";
            this.LBInProgressQuantity.Size = new System.Drawing.Size(46, 46);
            this.LBInProgressQuantity.TabIndex = 13;
            this.LBInProgressQuantity.Text = "10";
            this.LBInProgressQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "In Progress";
            // 
            // NexUpContainer
            // 
            this.NexUpContainer.BackColor = System.Drawing.Color.Transparent;
            this.NexUpContainer.BaseColor = System.Drawing.Color.White;
            this.NexUpContainer.Controls.Add(this.gunaCircleButton1);
            this.NexUpContainer.Controls.Add(this.LBNextUpQuantity);
            this.NexUpContainer.Controls.Add(this.label1);
            this.NexUpContainer.Location = new System.Drawing.Point(35, 23);
            this.NexUpContainer.Name = "NexUpContainer";
            this.NexUpContainer.Radius = 7;
            this.NexUpContainer.ShadowColor = System.Drawing.Color.Silver;
            this.NexUpContainer.ShadowShift = 4;
            this.NexUpContainer.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.NexUpContainer.Size = new System.Drawing.Size(266, 97);
            this.NexUpContainer.TabIndex = 1;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::TaskManagement.Properties.Resources.check_circle;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.Location = new System.Drawing.Point(181, 24);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(50, 48);
            this.gunaCircleButton1.TabIndex = 12;
            // 
            // LBNextUpQuantity
            // 
            this.LBNextUpQuantity.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNextUpQuantity.ForeColor = System.Drawing.Color.Black;
            this.LBNextUpQuantity.Location = new System.Drawing.Point(28, 16);
            this.LBNextUpQuantity.Name = "LBNextUpQuantity";
            this.LBNextUpQuantity.Size = new System.Drawing.Size(46, 46);
            this.LBNextUpQuantity.TabIndex = 11;
            this.LBNextUpQuantity.Text = "10";
            this.LBNextUpQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Next Up";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(38, 62);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(626, 230);
            this.cartesianChart2.TabIndex = 15;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // DashboardBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardBaseControl";
            this.Size = new System.Drawing.Size(1180, 825);
            this.Load += new System.EventHandler(this.DashboardBaseControl_Load);
            this.MainContainer.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.seconChartContainer.ResumeLayout(false);
            this.seconChartContainer.PerformLayout();
            this.firstChartContainer.ResumeLayout(false);
            this.firstChartContainer.PerformLayout();
            this.EmployeesContainer.ResumeLayout(false);
            this.EmployeesContainer.PerformLayout();
            this.CompletedContainer.ResumeLayout(false);
            this.CompletedContainer.PerformLayout();
            this.InProgressContainer.ResumeLayout(false);
            this.InProgressContainer.PerformLayout();
            this.NexUpContainer.ResumeLayout(false);
            this.NexUpContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MainContainer;
        private Guna.UI.WinForms.GunaShadowPanel EmployeesContainer;
        private Guna.UI.WinForms.GunaShadowPanel CompletedContainer;
        private Guna.UI.WinForms.GunaShadowPanel InProgressContainer;
        private Guna.UI.WinForms.GunaShadowPanel NexUpContainer;
        private System.Windows.Forms.Label LBNextUpQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBInProgressQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBEmployeesQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBCompletedQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton3;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton4;
        private Guna.UI.WinForms.GunaShadowPanel firstChartContainer;
        private Guna.UI.WinForms.GunaShadowPanel seconChartContainer;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CartesianChart cartesianChart1;
        private PieChart pieChart1;
        private CartesianChart cartesianChart2;
    }
}
