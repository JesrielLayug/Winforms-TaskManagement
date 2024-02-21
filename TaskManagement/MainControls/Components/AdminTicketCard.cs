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
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;
using TaskManagement.Views;

namespace TaskManagement.UserControls.Components
{
    public partial class AdminTicketCard : UserControl
    {
        public TicketInfo ticket;
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;

        public event EventHandler UpdateClick;
        public event EventHandler DeleteClick;

        public AdminTicketCard(
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
            LBDate.Text = ticket.DueDate;
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            AdminTicketView view = new AdminTicketView(ticket);
            view.ShowDialog();
        }

        private async void BTNUpdate_Click(object sender, EventArgs e)
        {
            TicketEditorView editor = new TicketEditorView(ticket, null, userService, ticketService, requestService, logsService);
            editor.ShowDialog();
            var dialog = editor.DialogResult;

            if(dialog == DialogResult.OK)
            {
                await logsService.Add($"Updated the ticket: {ticket.Title}");
                UpdateClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private async void BTNDelete_Click(object sender, EventArgs e)
        {
            await logsService.Add($"Deleted the ticket: {ticket.Title}");
            DeleteClick?.Invoke(this, EventArgs.Empty);
        }

        
    }
}
