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
    public partial class EmployeeTicketView : Form
    {
        TicketInfo ticket;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        bool isComboBoxChanged = false;

        public EmployeeTicketView(TicketInfo ticket, IEmployeeRequestService requestService, ILogsService logsService)
        {
            this.ticket = ticket;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeTexts();
        }

        private void InitializeTexts()
        {
            LBTicketName.Text = ticket.Title;
            LBPriority.Text = ticket.Priority;
            LBStartDate.Text = ticket.StartDate;
            LBDueDate.Text = ticket.DueDate;
            LBAssignee.Text = ticket.AssignUserName;
            LBDivision.Text = ticket.Division;
            LBDescription.Text = ticket.Description;
            CBStatus.SelectedItem = ticket.TicketStatus;
            LBIssuer.Text = ticket.CreatorFullName;
        }

        private async void BTNSubmit_Click(object sender, EventArgs e)
        {
            var existingRequest = await requestService.GetByTitle(ticket.Title);

            if (isComboBoxChanged)
            {
                if (CBStatus.Text != ticket.TicketStatus)
                {
                    if (existingRequest != null)
                        MessageBox.Show("Ticket already requested.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        var requestTicket = new EmployeeTicketInfo
                        {
                            Id = ticket.Id,
                            TicketId = ticket.Id,
                            Title = ticket.Title,
                            AssignName = ticket.AssignUserName,
                            Priority = ticket.Priority,
                            Division = ticket.Division,
                            TicketStatus = CBStatus.Text,
                            StartDate = ticket.StartDate,
                            DueDate = ticket.DueDate,
                            Description = ticket.Description,
                        };

                        var response = await requestService.Add(requestTicket);
                        if (response.IsSuccess)
                        {
                            var dialog = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                await logsService.Add($"Requested to update the ticket: {ticket.Title}");
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("Unable to send request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                   MessageBox.Show("You did not request for any change", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Please select what kind of request", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isComboBoxChanged = true;
            BTNSubmit.Enabled = true;
        }
    }
}
