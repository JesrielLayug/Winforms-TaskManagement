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
using TaskManagement.Utilities;
using TaskManagement.Views;

namespace TaskManagement.MainControls.SubControls
{
    public partial class AccountBaseControl : UserControl
    {
        private UserSettingsProvider SettingsProvider = new UserSettingsProvider();

        private UserEditor Employee;

        private readonly IUserService userService;
        private readonly IAuthenticationService authenticationService;
        private IEnumerable<User> Employees;
        private List<UserEditor> userEditors;

        public AccountBaseControl(IUserService userService, IAuthenticationService authenticationService)
        {
            this.userService = userService;
            this.authenticationService = authenticationService;
            InitializeComponent();
            InitializeDataGridView();
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                if (Employee != null)
                {
                    //var response = await authenticationService.Register(new UserEditor
                    //{
                    //    Role = "Employee",
                    //    Gender = CBGender.Text,
                    //    FullName = $"{TBFirstname.Text} {TBLastname.Text}",
                    //    Position = CBPosition.Text,
                    //    Email = TBEmail.Text,
                    //    Password = TBPassword.Text,
                    //    Authorization = CBAuthorization.Text
                    //});

                    //if (response.IsSuccess)
                    //{
                    //    MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    InitializeDataGridView();
                    //}
                    var userTobeUpdate = new User
                    {
                        Role = "Employee",
                        Gender = CBGender.Text,
                        FullName = $"{TBFirstname.Text} {TBLastname.Text}",
                        Position = CBPosition.Text,
                        Email = TBEmail.Text,
                        Authorization = CBAuthorization.Text
                    };

                    var response = await userService.Update(userTobeUpdate, Employee.FullName);
                    if (response.IsSuccess)
                    {
                        MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeDataGridView();
                    }
                }
            }
            else
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void InitializeDataGridView()
        {
            userEditors = new List<UserEditor>();

            var role = SettingsProvider.GetCurrentUserRole();
            if(role == "Admin")
            {
                var users = await userService.GetAllEmployee();

                foreach (var user in users)
                {
                    userEditors.Add(new UserEditor
                    {
                        Role = user.Role,
                        FullName = user.FullName,
                        Gender = user.Gender,
                        Position = user.Position,
                        Email = user.Email,
                        Authorization = user.Authorization,
                    });
                }
            }
            else
            {
                var users = await userService.GetAllAdminAndEmployee();

                foreach (var user in users)
                {
                    userEditors.Add(new UserEditor
                    {
                        Role = user.Role,
                        FullName = user.FullName,
                        Gender = user.Gender,
                        Position = user.Position,
                        Email = user.Email,
                        Authorization = user.Authorization,
                    });
                }
            }
            

            DGVUsers.DataSource = userEditors;
        }
        private void PopulateTextBoxes(UserEditor user)
        {

            if(user != null)
            {
                string[] words = user.FullName.Split(' ');
                var firstname = words[0];
                var lastname = words[1];
                CBGender.SelectedItem = user.Gender;
                TBFirstname.Text = firstname;
                TBLastname.Text = lastname;
                CBPosition.SelectedItem = user.Position;
                TBEmail.Text = user.Email;
                CBAuthorization.SelectedItem = user.Authorization;
            }
        }

        private void DGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGVUsers.SelectedRows[0];

                if (selectedRow.DataBoundItem is UserEditor)
                {
                    UserEditor clickedUser = (UserEditor)selectedRow.DataBoundItem;
                    Employee = clickedUser;
                    PopulateTextBoxes(Employee);

                    // Check if EmployeeDetailsPanel is already added to EmployeeDetailsContainer
                    if (!EmployeeDetailsContainer.Controls.Contains(EmployeeDetailsPanel))
                    {
                        EmployeeDetailsContainer.Controls.Clear(); // Clear existing controls
                        EmployeeDetailsContainer.Controls.Add(EmployeeDetailsPanel);
                    }
                }
            }
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            Employee = null;
            ClearAllFields();
        }

        private async void BTNDelete_Click(object sender, EventArgs e)
        {
            var response = await userService.Delete(Employee);
            if(response.IsSuccess)
            {
                MessageBox.Show(response.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeDataGridView();
            }
        }

        private void ClearAllFields()
        {
            CBGender.SelectedItem = null;
            TBFirstname.Text = string.Empty;
            TBLastname.Text = string.Empty;
            CBPosition.SelectedItem = null;
            TBEmail.Text = string.Empty;
            CBAuthorization.SelectedItem = null;
        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(CBAuthorization.Text) &&
               !string.IsNullOrEmpty(CBGender.Text) &&
               !string.IsNullOrEmpty(CBPosition.Text) &&
               !string.IsNullOrEmpty(TBFirstname.Text) &&
               !string.IsNullOrEmpty(TBLastname.Text) &&
               !string.IsNullOrEmpty(TBEmail.Text))
                return true;

            return false;
        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            var role = SettingsProvider.GetCurrentUserRole();
            if(role == "Super Admin")
            {
                SuperRegisterView superRegister = new SuperRegisterView(authenticationService);
                superRegister.RegisterClick += async (s, ex) => { InitializeDataGridView(); };
                superRegister.ShowDialog();
            }
            else
            {
                RegisterView register = new RegisterView(authenticationService);
                register.RegisterClick += async (s, ex) => { InitializeDataGridView(); };
                register.ShowDialog();
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = TBSearch.Text.ToLower();

            var filteredUsers = userEditors.Where(user =>
                user.Role.ToLower().Contains(searchTerm) ||
                user.FullName.ToLower().Contains(searchTerm) ||
                user.Gender.ToLower().Contains(searchTerm) ||
                user.Position.ToLower().Contains(searchTerm) ||
                user.Email.ToLower().Contains(searchTerm) ||
                user.Authorization.ToLower().Contains(searchTerm) 
            ).ToList();

            DGVUsers.DataSource = filteredUsers;
        }
    }
}
