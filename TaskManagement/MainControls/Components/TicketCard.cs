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
    public partial class TicketCard : UserControl
    {
        public TicketInfo ticket;
        private readonly IUserService userService;
        private readonly ITicketService ticketService;

        public event EventHandler UpdateClick;
        public event EventHandler DeleteClick;

        public TicketCard(TicketInfo ticket, IUserService userService, ITicketService ticketService)
        {
            this.ticket = ticket;
            this.userService = userService;
            this.ticketService = ticketService;
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
            TicketView view = new TicketView(ticket);
            view.ShowDialog();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            AdminTicketEditorView editor = new AdminTicketEditorView(ticket, userService, ticketService);
            editor.ShowDialog();
            var dialog = editor.DialogResult;

            if(dialog == DialogResult.OK)
                UpdateClick?.Invoke(this, EventArgs.Empty);
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, EventArgs.Empty);
        }

        
    }
}
