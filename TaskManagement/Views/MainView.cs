﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.MainControls;
using TaskManagement.Services.Contracts;
using TaskManagement.UserControls;

namespace TaskManagement.Views
{
    public partial class MainView : Form
    {
        private readonly IUserService userService;
        private readonly ITicketService taskService;

        public string role { get; set; }
        public MainView(
            string role, 
            IUserService userService,
            ITicketService taskService
            )
        {
            this.userService = userService;
            this.taskService = taskService;
            this.role = role;

            InitializeComponent();
            InitializeInRoleView();
        }

        public void InitializeInRoleView()
        {
            if (role == "Admin")
            {
                AdminControl adminControl = new AdminControl(userService, taskService);
                adminControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(adminControl);
            }
            else
            {
                EmployeeControl employeeControl = new EmployeeControl();
                employeeControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(employeeControl);
            }
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
