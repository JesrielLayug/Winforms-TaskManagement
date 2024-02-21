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
using TaskManagement.UserControls.Components;
using TaskManagement.Views;

namespace TaskManagement.UserControls.AdminSubControls
{
    public partial class TicketControl : UserControl
    {
        public event EventHandler DeleteClick;
        public event EventHandler UpdateClick;

        public IEnumerable<TicketInfo> TicketInfos;
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        public TicketControl
            (
            IEnumerable<TicketInfo> ticketInfos,
            IUserService userService,
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            ILogsService logsService
            )
        {
            this.TicketInfos = ticketInfos;
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeAllFlowLayouts();
        }

        private void InitializeAllFlowLayouts()
        {
            var groupedByStatus = TicketInfos.GroupBy(ticket => ticket.TicketStatus);

            List<TicketInfo> nextUpTickets = groupedByStatus.FirstOrDefault(g => g.Key == "Next Up")?.ToList() ?? null;
            List<TicketInfo> inProgressTickets = groupedByStatus.FirstOrDefault(g => g.Key == "In Progress")?.ToList() ?? null;
            List<TicketInfo> completedTickets = groupedByStatus.FirstOrDefault(g => g.Key == "Completed")?.ToList() ?? null;

            InitializeNextUp(nextUpTickets);
            InitializeInProgress(inProgressTickets);
            InitializeCompleted(completedTickets);
        }

        public void InitializeNextUp(List<TicketInfo> tickets)
        {
            FLPNextUp.Controls.Clear();

            if (tickets != null)
            {
                NextUpCount.Text = tickets.Count.ToString();

                foreach (var ticket in tickets)
                {
                    if (string.IsNullOrEmpty(ticket.Title))
                        continue;

                    AdminTicketCard card = new AdminTicketCard(ticket, userService, ticketService, requestService, logsService);
                    card.DeleteClick += (s, e) => HandleDeleteClick(ticket);
                    card.UpdateClick += (s, e) => { UpdateClick?.Invoke(this, EventArgs.Empty); };

                    FLPNextUp.Controls.Add(card);
                }
            }
        }

        public void InitializeInProgress(List<TicketInfo> tickets)
        {
            FLPInProgress.Controls.Clear();

            if(tickets != null)
            {
                InProgressCount.Text = tickets.Count.ToString();

                foreach (var ticket in tickets)
                {
                    if (String.IsNullOrEmpty(ticket.Title))
                        continue;

                    AdminTicketCard card = new AdminTicketCard(ticket, userService, ticketService, requestService, logsService); ;
                    card.DeleteClick += (s, e) => HandleDeleteClick(ticket);
                    card.UpdateClick += (s, e) => { 
                        UpdateClick?.Invoke(this, EventArgs.Empty); 
                    };

                    FLPInProgress.Controls.Add(card);
                }
            }
        }

        public void InitializeCompleted(List<TicketInfo> tickets)
        {
            FLPCompleted.Controls.Clear();

            if(tickets != null)
            {
                CompletedCount.Text = tickets.Count.ToString();

                foreach (var ticket in tickets)
                {

                    if (String.IsNullOrEmpty(ticket.Title))
                        continue;

                    AdminTicketCard card = new AdminTicketCard(ticket, userService, ticketService, requestService, logsService) ;
                    card.DeleteClick += (s, e) => HandleDeleteClick(ticket);
                    card.UpdateClick += (s, e) => { UpdateClick?.Invoke(this, EventArgs.Empty); };

                    FLPCompleted.Controls.Add(card);
                }
            }
        }

        private async void HandleDeleteClick(TicketInfo ticket)
        {
            var dialogResult = MessageBox.Show($"Are you sure you want to delete {ticket.Title}?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                await ticketService.Delete(ticket.Id);
                DeleteClick?.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
