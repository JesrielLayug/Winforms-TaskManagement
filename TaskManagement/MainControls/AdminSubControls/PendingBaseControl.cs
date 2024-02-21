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
using TaskManagement.UserControls;
using TaskManagement.Utilities;

namespace TaskManagement.MainControls.SubControls
{
    public partial class PendingBaseControl : UserControl
    {
        private ButtonClickHandler ApprovedClickHandler;

        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;
        IEnumerable<EmployeeTicketInfo> Tickets;
        EmployeeTicketInfo Ticket = new EmployeeTicketInfo();

        public PendingBaseControl(
            IUserService userService,
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            ILogsService logsService)
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.logsService = logsService;

            // handles buttons click
            ApprovedClickHandler = new ButtonClickHandler();

            InitializeComponent();
            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            MainContainer.Controls.Clear();
            Tickets = await requestService.GetAll();

            if (Tickets.Count() > 0)
            {
                MainContainer.Controls.Add(ContentContainer);

                DGVRequests.DataSource = Tickets;

                if (DGVRequests.Rows.Count > 0)
                {
                    Ticket = (EmployeeTicketInfo)DGVRequests.Rows[0].DataBoundItem;

                    PopulateFields(Ticket);
                }
            }
            else
            {
                EmptyControl empty = new EmptyControl();
                empty.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(empty);
            }
        }

        private void PopulateFields(EmployeeTicketInfo Ticket)
        {
            LBTicketName.Text = Ticket.Title;
            LBStatus.Text = Ticket.TicketStatus;
            LBDescription.Text = Ticket.Description;
            LBPriority.Text = Ticket.Priority;
            LBDueDate.Text = Ticket.DueDate;
            LBDivision.Text = Ticket.Division;
            LBAssignee.Text = Ticket.AssignName;
            LBStartDate.Text = Ticket.StartDate;
            LBRequestCreated.Text = Ticket.DateRequestCreated;
        }

        private void DGVRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = DGVRequests.SelectedRows[0];

                if (selected.DataBoundItem is EmployeeTicketInfo)
                {
                    EmployeeTicketInfo clickedTicket = (EmployeeTicketInfo)selected.DataBoundItem;
                    PopulateFields(clickedTicket);

                    if (!TicketDetailsContainer.Controls.Contains(TicketDetails))
                    {
                        TicketDetailsContainer.Controls.Clear();
                        TicketDetailsContainer.Controls.Add(TicketDetails);
                    }
                }
            }
        }

        private async void BTNApproved_Click(object sender, EventArgs e)
        {
            var existingApprovedTicket = await ticketService.GetById(Ticket.TicketId);

            TicketEditor newTicket = new TicketEditor
            {
                Title = Ticket.Title,
                AssignName = Ticket.AssignName,
                Priority = Ticket.Priority,
                Division = Ticket.Division,
                TicketStatus = Ticket.TicketStatus,
                StartDate = Ticket.StartDate,
                DueDate = Ticket.DueDate,
                Description = Ticket.Description,
                IsApproved = true,
                CreatedBy = Ticket.RequestorName
            };


            if (existingApprovedTicket == null)
            {
                var response = await ticketService.Add(newTicket);
                if (response.IsSuccess)
                {
                    await requestService.Delete(Ticket);
                    MessageBox.Show("Ticket is successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDataGridView();

                    await logsService.Add($"Approved to add the ticket: {Ticket.Title}");
                }
                else
                    MessageBox.Show("Failed to approve the ticket", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var response = await ticketService.Update(newTicket, Ticket.TicketId);
                if (response.IsSuccess)
                {
                    Ticket.IsApproved = true;
                    await requestService.Update(Ticket);
                    MessageBox.Show("Ticket is successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDataGridView();

                    await logsService.Add($"Approved to update the ticket: {Ticket.Title}");
                }
            }

            ApprovedClickHandler.HandleButtonClick(sender, e);
        }

        private async void BTNCancel_Click(object sender, EventArgs e)
        {
            Ticket.IsCancelled = true;
            await logsService.Add($"Cancelled the ticket: {Ticket.Title}");
            var response = await requestService.Update(Ticket);
            if(response.IsSuccess)
            {
                MessageBox.Show("Ticket is cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeDataGridView();
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string searchText = TBSearch.Text.ToLower();

            var filteredUsers = Tickets.Where(ticket =>
                ticket.Description.ToLower().Contains(searchText) ||
                ticket.Title.ToLower().Contains(searchText) ||
                ticket.Division.ToLower().Contains(searchText) ||
                ticket.Priority.ToLower().Contains(searchText)
            ).ToList();

            DGVRequests.DataSource = filteredUsers;
        }
    }
}
