using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class LoginView : Form
    {
        private readonly IAuthenticationService authenticationService;
        private readonly IUserService userService;
        private readonly ITicketService taskService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        public LoginView(
            IAuthenticationService authenticationService, 
            IUserService userService,
            ITicketService taskService,
            IEmployeeRequestService requestService,
            ILogsService logsService
            )
        {
            this.authenticationService = authenticationService;
            this.userService = userService;
            this.taskService = taskService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
        }

        private async void BTNLogin_Click(object sender, EventArgs e)
        {

            if (CheckAllFields())
            {
                var response = await authenticationService.Login(TBEmail.Text, TBPassword.Text);

                if (response.IsWrongEmail)
                    MessageBox.Show(response.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (response.IsWrongPassword)
                    MessageBox.Show(response.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!response.IsAuthorized)
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Hide();
                    this.ShowInTaskbar = false;


                    if (response.Role == "Admin" || response.Role == "Super Admin")
                    {
                        await logsService.Add("Logged in");
                        MainView mainView = new MainView(response.Role, userService, taskService, requestService, authenticationService, logsService);
                        mainView.Show();
                    }
                    else
                    {
                        await logsService.Add("Logged in");
                        MainView mainView = new MainView(response.Role, userService, taskService, requestService, authenticationService, logsService);
                        mainView.Show();
                    }
                }
            }
            else
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(TBEmail.Text) && !string.IsNullOrEmpty(TBPassword.Text))
                return true;
            return false;
        }

        private void TogglePasswordVisibility(GunaTextBox textBox, GunaCheckBox checkBox)
        {
            textBox.PasswordChar = checkBox.Checked ? '\0' : '●';
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(TBPassword, CBShowPassword);
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LinkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(userService, authenticationService, logsService);
            forgotPassword.ShowDialog();
        }
    }
}
