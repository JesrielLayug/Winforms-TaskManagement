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
using TaskManagement.Services;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class RegisterView : Form
    {
        public event EventHandler RegisterClick;
        private readonly IAuthenticationService authenticationService;

        public RegisterView(IAuthenticationService authenticationService)
        {
            InitializeComponent();
            this.authenticationService = authenticationService;
        }

        private async void BTNRegister_Click(object sender, EventArgs e)
        {
            if(CheckAllFields())
            {
                var response = await authenticationService.Register(new UserEditor
                {
                    Role = "Employee",
                    Gender = CBGender.Text,
                    FullName = $"{TBFirstname.Text} {TBLastname.Text}",
                    Position = CBPosition.Text,
                    Email = TBEmail.Text,
                    Password = TBPassword.Text,
                    Authorization = CBAuthorization.Text
                });

                if (response.IsSuccess)
                {
                    var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dialog == DialogResult.OK)
                    {
                        RegisterClick?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                }
            }
        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(CBAuthorization.Text) &&
               !string.IsNullOrEmpty(CBGender.Text) &&
               !string.IsNullOrEmpty(CBPosition.Text) &&
               !string.IsNullOrEmpty(TBFirstname.Text) &&
               !string.IsNullOrEmpty(TBLastname.Text) &&
               !string.IsNullOrEmpty(TBEmail.Text) &&
               !string.IsNullOrEmpty(TBPassword.Text))
                return true;

            return false;
        }
    }
}
