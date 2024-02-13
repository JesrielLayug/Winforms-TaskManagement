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

namespace TaskManagement
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService userService;

        public RegisterForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await userService.Add(new UserEditor
            {
                Role = TBRole.Text,
                Gender = TBGender.Text,
                FullName = TBFname.Text,
                Position = TBPosition.Text,
                Email = TBEmail.Text,
                Password = TBEmail.Text,
            });

            if(response.IsSuccess )
            {
                MessageBox.Show(response.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
