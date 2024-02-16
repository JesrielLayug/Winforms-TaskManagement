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
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class ForgotPassword : Form
    {
        private readonly IUserService userService;

        public ForgotPassword(IUserService userService)
        {
            this.userService = userService;
            InitializeComponent();
        }

        private void TogglePasswordVisibility(GunaTextBox textBox, GunaCheckBox checkBox)
        {
            textBox.PasswordChar = checkBox.Checked ? '\0' : '●';
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            var response = await userService.ChangePassword(TBEmail.Text, TBNewPassword.Text);
            if (response.IsSuccess)
            {
                var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dialog == DialogResult.OK)
                    this.Close();
            }
            else
            {
                var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                    this.Close();
            }
        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(TBNewPassword, CBShowPassword);
        }
    }
}
