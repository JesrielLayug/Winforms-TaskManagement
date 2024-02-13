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
using TaskManagement.UserControls.Components;

namespace TaskManagement.UserControls.AdminSubControls
{
    public partial class TicketControl : UserControl
    {
        public IEnumerable<TicketInfo> TicketInfos;

        public TicketControl(IEnumerable<TicketInfo> ticketInfos)
        {
            this.TicketInfos = ticketInfos;

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

            if(tickets != null)
            {
                foreach (var ticket in tickets)
                {
                    if (!String.IsNullOrEmpty(ticket.Title))
                    {
                        TicketCard card = new TicketCard(ticket.Title, ticket.Description, ticket.DueDate);
                        FLPNextUp.Controls.Add(card);
                    }
                    else
                        break;
                }
            }
        }

        public void InitializeInProgress(List<TicketInfo> tickets)
        {
            FLPInProgress.Controls.Clear();

            if(tickets != null)
            {
                foreach (var ticket in tickets)
                {
                    if (!String.IsNullOrEmpty(ticket.Title))
                    {
                        TicketCard card = new TicketCard(ticket.Title, ticket.Description, ticket.DueDate);
                        FLPInProgress.Controls.Add(card);
                    }
                    else
                        break;
                }
            }
        }

        public void InitializeCompleted(List<TicketInfo> tickets)
        {
            FLPCompleted.Controls.Clear();

            if(tickets != null)
            {
                foreach (var ticket in tickets)
                {

                    if (!String.IsNullOrEmpty(ticket.Title))
                    {
                        TicketCard card = new TicketCard(ticket.Title, ticket.Description, ticket.DueDate);
                        FLPCompleted.Controls.Add(card);
                    }
                    else
                        break;
                }
            }
        }
    }
}
