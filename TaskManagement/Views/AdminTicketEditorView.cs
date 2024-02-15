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
using TaskManagement.Services;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Views
{
    public partial class AdminTicketEditorView : Form
    {
        public event EventHandler TicketAdded;
        public event EventHandler TicketUpdated;

        public TicketInfo Ticket;

        private readonly IUserService userService;
        private readonly ITicketService ticketService;

        private IEnumerable<User> Users;

        public AdminTicketEditorView (
            TicketInfo Ticket,
            IUserService userService, 
            ITicketService taskService
            )
        {
            this.Ticket = Ticket;
            this.userService = userService;
            this.ticketService = taskService;

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
                    IsApprove = true
                };

                if (Ticket == null)
                {
                    await AddTicket(ticket);
                }
                else
                {
                    ticket.IsApprove = true;
                    await UpdateTicket(ticket, Ticket.Id);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddTicket(TicketEditor ticket)
        {
            var response = await ticketService.Add(ticket);
            if (response.IsSuccess)
            {
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
                TicketUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
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


    }
}
