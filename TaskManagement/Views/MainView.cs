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
        private readonly IEmployeeRequestService requestService;
        private readonly IAuthenticationService authenticationService;
        private readonly ILogsService logsService;

        public string role { get; set; }
        public MainView(
            string role, 
            IUserService userService,
            ITicketService taskService,
            IEmployeeRequestService requestService,
            IAuthenticationService authenticationService,
            ILogsService logsService
            )
        {
            this.userService = userService;
            this.taskService = taskService;
            this.requestService = requestService;
            this.authenticationService = authenticationService;
            this.logsService = logsService;
            this.role = role;

            InitializeComponent();
            InitializeInRoleView();
        }

        public void InitializeInRoleView()
        {
            if (role == "Admin" || role == "Super Admin")
            {
                AdminControl adminControl = new AdminControl(userService, taskService, authenticationService, requestService, logsService);
                adminControl.LogoutClick += (s, ex) => 
                {
                    logsService.Add("Logged out");
                    this.Close(); 
                };
                adminControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(adminControl);
            }
            else
            {
                EmployeeControl employeeControl = new EmployeeControl(userService, taskService, requestService, authenticationService, logsService);
                employeeControl.LogoutClick += (s, ex) => 
                {
                    logsService.Add("Logged out");
                    this.Close(); 
                };
                employeeControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(employeeControl);
            }
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginView loginView = new LoginView(
                authenticationService, 
                userService, 
                taskService, 
                requestService,
                logsService);
            loginView.Show();
        }
    }
}
