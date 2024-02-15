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
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class LoginView : Form
    {
        private readonly IAuthenticationService authenticationService;
        private readonly IUserService userService;
        private readonly ITicketService taskService;
        private readonly IEmployeeRequestService requestService;

        public LoginView(
            IAuthenticationService authenticationService, 
            IUserService userService,
            ITicketService taskService,
            IEmployeeRequestService requestService
            )
        {
            this.authenticationService = authenticationService;
            this.userService = userService;
            this.taskService = taskService;
            this.requestService = requestService;
            InitializeComponent();
        }

        private async void BTNLogin_Click(object sender, EventArgs e)
        {
            var response = await authenticationService.Login(TBEmail.Text, TBPassword.Text);

            if(response.IsWrongEmail)
                MessageBox.Show(response.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(response.IsWrongPassword)
                MessageBox.Show(response.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                this.ShowInTaskbar = false;


                if (response.Role == "Admin")
                {
                    MainView mainView = new MainView(response.Role, userService, taskService, requestService, authenticationService);
                    mainView.Show();
                }
                else
                {
                    MainView mainView = new MainView(response.Role, userService, taskService, requestService, authenticationService);
                    mainView.Show();
                }
            }
        }

        private void TogglePasswordVisibility(GunaTextBox textBox, GunaCheckBox checkBox)
        {
            textBox.PasswordChar = checkBox.Checked ? '\0' : '●';
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(TBPassword, CBShowPassword);
        }
    }
}
