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

namespace TaskManagement.MainControls.Components
{
    public partial class EmployeeTicketCard : UserControl
    {
        public TicketInfo ticket;
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        public EmployeeTicketCard(
            TicketInfo ticket, 
            IUserService userService, 
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            ILogsService logsService)
        {
            this.ticket = ticket;
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeTexts();
        }

        private void InitializeTexts()
        {
            LBTitle.Text = ticket.Title;
            LBDescription.Text = ticket.Description;
            BTNDate.Text = ticket.DueDate;
            BTNPriority.Text = ticket.Priority;
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            EmployeeTicketView view = new EmployeeTicketView(ticket, requestService, logsService);
            view.ShowDialog();
        }
    }
}
