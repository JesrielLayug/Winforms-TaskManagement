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
    public partial class TicketEditorView : Form
    {
        public event EventHandler TicketAdded;

        private readonly IUserService userService;
        private readonly ITicketService taskService;
        private IEnumerable<User> Users;

        public TicketEditorView (
            IUserService userService, 
            ITicketService taskService
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
                CBCreator.Items.Add(user.FullName);
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
                var newTask = new TicketEditor
                {
                    Title = TBTitle.Text,
                    AssignName = CBAssignTo.Text,
                    Priority = CBPriority.Text,
                    Division = TBDivision.Text,
                    TicketStatus = CBTaskStatus.Text,
                    StartDate = TBStartDate.Text,
                    DueDate = TBDueDate.Text,
                    Description = TBDescription.Text,
                    CreatedBy = CBCreator.Text,
                };

                var response = await taskService.Add(newTask);
                if (response.IsSuccess)
                {
                    TicketAdded?.Invoke(this, EventArgs.Empty);
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
                    targetTextBox.Text = calendarForm.SelectedDate.ToString("MMM dd");
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
                !string.IsNullOrEmpty(CBCreator.Text)
               )
            {
                return true;
            }
            return false;
        }
    }
}
