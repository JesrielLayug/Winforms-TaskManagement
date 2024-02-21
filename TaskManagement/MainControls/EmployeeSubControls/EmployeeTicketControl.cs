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
using TaskManagement.UserControls.AdminSubControls;
using TaskManagement.UserControls;
using TaskManagement.Views;

namespace TaskManagement.MainControls.EmployeeSubControls
{
    public partial class EmployeeTicketControl : UserControl
    {

        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;
        private IEnumerable<TicketInfo> Tickets = new List<TicketInfo>();

        public EmployeeTicketControl(
            IUserService userService, 
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            ILogsService logsService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeContainer();
        }


        private async void InitializeContainer()
        {
            Container.Controls.Clear();
            Tickets = await ticketService.GetAll();

            if (Tickets != null && Tickets.Any())
            {
                EmployeeTicketSubControl ticketControl = new EmployeeTicketSubControl(
                    Tickets, 
                    userService, 
                    ticketService,
                    requestService,
                    logsService);

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

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            TicketEditorView create = new TicketEditorView(null, null, userService, ticketService, requestService, logsService);
            create.TicketRequestAdded += (s, ex) => { InitializeContainer(); };
            create.ShowDialog();
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

                EmployeeTicketSubControl ticketControl = new EmployeeTicketSubControl(
                    filteredTickets,
                    userService,
                    ticketService,
                    requestService, logsService);

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
