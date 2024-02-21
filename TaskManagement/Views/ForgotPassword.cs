using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class ForgotPassword : Form
    {
        private readonly IUserService userService;
        private readonly IAuthenticationService authenticationService;

        public ForgotPassword(IUserService userService, IAuthenticationService authenticationService)
        {
            this.userService = userService;
            this.authenticationService = authenticationService;
            InitializeComponent();
        }

        private void TogglePasswordVisibility(GunaTextBox textBox, GunaCheckBox checkBox)
        {
            textBox.PasswordChar = checkBox.Checked ? '\0' : '●';
        }

        private bool CheckAllFields()
        {
            if(!string.IsNullOrEmpty(TBEmail.Text) && !string.IsNullOrEmpty(TBNewPassword.Text)) 
                return true;

            return false;
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {

            if (CheckAllFields())
            {
                var response = await authenticationService.ResetPassword(TBEmail.Text, TBNewPassword.Text);
                if (response.IsSuccess)
                {
                    var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                        this.Close();
                }
                else
                {
                    var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                        this.Close();
                }
            }
            else

                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(TBNewPassword, CBShowPassword);
        }
    }
}
