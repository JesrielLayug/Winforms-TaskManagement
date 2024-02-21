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
using TaskManagement.Views;

namespace TaskManagement.UserControls.AdminSubControls
{
    public partial class TicketBaseControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private IEnumerable<TicketInfo> Tickets = new List<TicketInfo>();

        public TicketBaseControl(
            IUserService userService,
            ITicketService ticketService,
            IEmployeeRequestService requestService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            InitializeComponent();
            InitializeContainer();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            TicketEditorView create = new TicketEditorView(null, null, userService, ticketService, requestService);
            create.TicketAdded += (s, ex) => { InitializeContainer(); };
            create.ShowDialog();
        }


        private async void InitializeContainer()
        {
            Container.Controls.Clear();
            Tickets = await ticketService.GetAll();

            if (Tickets != null && Tickets.Any())
            {
                TicketControl ticketControl = new TicketControl(Tickets, userService, ticketService, requestService);
                
                ticketControl.DeleteClick += (s, ex) => { InitializeContainer(); };
                ticketControl.UpdateClick += (s, ev) => { InitializeContainer(); };
                
                ticketControl.Dock = DockStyle.Fill;
                Container.Controls.Add(ticketControl);
            }
            else
            {
                EmptyControl emptyControl = new EmptyControl();
                emptyControl.Dock = DockStyle.Fill;
                Container.Controls.Add(emptyControl);
            }

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string searchText = TBSearch.Text.Trim().ToLower(); 

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                List<TicketInfo> filteredTickets = Tickets.Where(ticket =>
                    ticket.Description.ToLower().Contains(searchText) || 
                    ticket.Title.ToLower().Contains(searchText) ||
                    ticket.Division.ToLower().Contains(searchText) ||
                    ticket.AssignUserName.ToLower().Contains(searchText) || 
                    ticket.Priority.ToLower().Contains(searchText)
                ).ToList();

                TicketControl ticketControl = new TicketControl(filteredTickets, userService, ticketService, requestService);

                ticketControl.DeleteClick += (s, ex) => { InitializeContainer(); };
                ticketControl.UpdateClick += (s, ev) => { InitializeContainer(); };

                ticketControl.Dock = DockStyle.Fill;
                Container.Controls.Clear(); 
                Container.Controls.Add(ticketControl);
            }
            else
            {
                InitializeContainer();
            }
        }
    }
}
