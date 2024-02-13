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
    public partial class EditorTaskView : Form
    {
        private readonly IUserService userService;
        private readonly ITaskService taskService;
        private IEnumerable<User> Users;

        public EditorTaskView (
            IUserService userService, 
            ITaskService taskService
            )
        {

            this.userService = userService;
            this.taskService = taskService;

            InitializeComponent();
            InitializedAllUsers();
        }
        
        private async Task InitializedAllUsers()
        {
            Users = await userService.GetAll();

            foreach(var user in Users)
            {
                CBAssignTo.Items.Add(user.FullName);
            }

        }

        private void BTNStartDate_Click(object sender, EventArgs e)
        {
            ShowCalendarForm(TBStartDate);
        }

        private void BTNDueDate_Click(object sender, EventArgs e)
        {
            ShowCalendarForm(TBDueDate);
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                var newTask = new TaskItemEditor
                {
                    Title = TBTitle.Text,
                    AssignName = CBAssignTo.Text,
                    Priority = CBPriority.Text,
                    Division = TBDivision.Text,
                    TaskStatus = CBTaskStatus.Text,
                    StartDate = TBStartDate.Text,
                    DueDate = TBDueDate.Text,
                    Description = TBDescription.Text,
                    CreatedBy = TBCreatedBy.Text,
                };

                var response = await taskService.Add(newTask);
                if (response.IsSuccess)
                {
                    MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCalendarForm(GunaTextBox targetTextBox)
        {
            using (CalendarView calendarForm = new CalendarView())
            {
                if (calendarForm.ShowDialog() == DialogResult.OK)
                {
                    targetTextBox.Text = calendarForm.SelectedDate.ToShortDateString();
                }
            }
        }

        private bool CheckAllFields()
        {
            if (
                !string.IsNullOrEmpty(TBTitle.Text) && !string.IsNullOrEmpty(CBAssignTo.Text) &&
                !string.IsNullOrEmpty(CBPriority.Text) && !string.IsNullOrEmpty(TBDivision.Text) &&
                !string.IsNullOrEmpty(CBTaskStatus.Text) && !string.IsNullOrEmpty(TBStartDate.Text) &&
                !string.IsNullOrEmpty(TBDueDate.Text) && !string.IsNullOrEmpty(TBDescription.Text) &&
                !string.IsNullOrEmpty(TBCreatedBy.Text)
               )
            {
                return true;
            }
            return false;
        }
    }
}
