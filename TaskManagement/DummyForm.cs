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

namespace TaskManagement
{
    public partial class DummyForm : Form
    {
        private readonly IAuthenticationService authenticationService;

        public DummyForm(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
            InitializeComponent();
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            await authenticationService.Register(new UserEditor
            {
                Role = "Admin",
                Gender = CBGender.Text,
                FullName = $"{TBFirstname.Text} {TBLastname.Text}",
                Position = CBPosition.Text,
                Email = TBEmail.Text,
                Password = TBPassword.Text,
                Authorization = CBAuthorization.Text
            });
        }
    }
}
