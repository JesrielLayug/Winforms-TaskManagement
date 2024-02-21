using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;
using TaskManagement.Services;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.Views
{
    public partial class TicketEditorView : Form
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        public TicketEditorView(
            TicketInfo Ticket,
            EmployeeTicketInfo Request,
            IUserService userService,
            ITicketService taskService,
            IEmployeeRequestService requestService,
            ILogsService logsService
            )
        {
            this.Ticket = Ticket;
            this.Request = Request;
            this.userService = userService;
            this.ticketService = taskService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializedAllUsers();
        }

        #region Properties

        public event EventHandler TicketAdded;
        public event EventHandler TicketUpdated;
        public event EventHandler TicketRequestAdded;
        public event EventHandler TicketRequestUpdated;

        public TicketInfo Ticket;
        public EmployeeTicketInfo Request;
        private IEnumerable<User> Users;

        private UserSettingsProvider settingsProvider = new UserSettingsProvider();

        #endregion

        #region Admin Methods

        private async Task AddTicket(TicketEditor ticket)
        {
            var response = await ticketService.Add(ticket);
            if (response.IsSuccess)
            {
                await logsService.Add($"Created the ticket: {Ticket.Title}.");
                TicketAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async Task UpdateTicket(TicketEditor ticket, string id)
        {
            var response = await ticketService.Update(ticket, id);
            if (response.IsSuccess)
            {
                await logsService.Add($"Updated the ticket: {Ticket.Title}.");
                TicketUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Employee Methods

        private async Task RequestAddTicket(EmployeeTicketInfo request)
        {
            var response = await requestService.Add(request);
            if (response.IsSuccess)
            {
                await logsService.Add($"Requested to add the ticket: {Ticket.Title}.");
                TicketRequestAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private async Task RequestUpdateTicket(EmployeeTicketInfo request)
        {
            await logsService.Add($"Requested to update the ticket: {Ticket.Title}.");
            var response = await requestService.Update(request);
            if (response.IsSuccess)
            {
                TicketRequestUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Click Events


        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                
                var currentUserRole = settingsProvider.GetCurrentUserRole();

                if(currentUserRole == "Admin")
                {
                    var ticket = new TicketEditor
                    {
                        Title = TBTitle.Text,
                        AssignName = CBAssignTo.Text,
                        Priority = CBPriority.Text,
                        Division = CBDivision.Text,
                        TicketStatus = CBTaskStatus.Text,
                        StartDate = TBStartDate.Text,
                        DueDate = TBDueDate.Text,
                        Description = TBDescription.Text,
                        CreatedBy = CBCreator.Text,
                        IsApproved = true
                    };

                    if (Ticket == null)
                    {
                        await AddTicket(ticket);
                    }
                    else
                    {
                        await UpdateTicket(ticket, Ticket.Id);
                    }
                }

                if(currentUserRole == "Employee")
                {
                    var ticket = new EmployeeTicketInfo
                    {
                        Id = Request.Id,
                        Title = TBTitle.Text,
                        AssignName = CBAssignTo.Text,
                        Priority = CBPriority.Text,
                        Division = CBDivision.Text,
                        TicketStatus = CBTaskStatus.Text,
                        StartDate = TBStartDate.Text,
                        DueDate = TBDueDate.Text,
                        Description = TBDescription.Text,
                        IsApproved = false
                    };

                    if (Request == null)
                        await RequestAddTicket(ticket);
                    else
                        await RequestUpdateTicket(ticket);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Initialization and Utility Methods

        private async Task InitializedAllUsers()
        {
            Users = await userService.GetAllEmployee();

            foreach(var user in Users)
            {
                CBAssignTo.Items.Add(user.FullName);
                CBCreator.Items.Add(user.FullName);
            }

            InitializedTicketsFields();

        }

        private async void InitializedTicketsFields()
        {
            //await InitializedAllUsers();

            if(Ticket != null && Users.Count() > 0)
            {
                TBTitle.Text = Ticket.Title;
                CBAssignTo.SelectedItem = Ticket.AssignUserName;
                CBDivision.SelectedItem = Ticket.Division;
                CBTaskStatus.SelectedItem = Ticket.TicketStatus;
                CBPriority.SelectedItem = Ticket.Priority;
                TBStartDate.Text = Ticket.StartDate;
                TBDueDate.Text = Ticket.DueDate;
                TBDescription.Text = Ticket.Description;
                CBCreator.SelectedItem = Ticket.CreatorFullName;
            }

            if(Request != null  && Users.Count() > 0)
            {
                TBTitle.Text = Request.Title;
                CBAssignTo.SelectedItem = Request.AssignName;
                CBDivision.SelectedItem = Request.Division;
                CBTaskStatus.SelectedItem = Request.TicketStatus;
                CBPriority.SelectedItem = Request.Priority;
                TBStartDate.Text = Request.StartDate;
                TBDueDate.Text = Request.DueDate;
                TBDescription.Text = Request.Description;
                CBCreator.SelectedItem = Request.RequestorName;

                CBCreator.Enabled = false;
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
                !string.IsNullOrEmpty(CBPriority.Text) && !string.IsNullOrEmpty(CBDivision.Text) &&
                !string.IsNullOrEmpty(CBTaskStatus.Text) && !string.IsNullOrEmpty(TBStartDate.Text) &&
                !string.IsNullOrEmpty(TBDueDate.Text) && !string.IsNullOrEmpty(TBDescription.Text) &&
                !string.IsNullOrEmpty(CBCreator.Text)
               )
            {
                return true;
            }
            return false;
        }


        #endregion

    }
}
