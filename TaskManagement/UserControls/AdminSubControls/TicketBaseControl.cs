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

        private IEnumerable<TicketInfo> Tickets = new List<TicketInfo>();

        public TicketBaseControl(
            IUserService userService,
            ITicketService ticketService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;

            InitializeComponent();
            InitializeContainer();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            TicketEditorView create = new TicketEditorView(userService, ticketService);
            create.TicketAdded += Create_TicketAdded;
            create.ShowDialog();
        }

        private async void Create_TicketAdded(object sender, EventArgs e)
        {
            InitializeContainer();
        }

        private async void InitializeContainer()
        {
            Container.Controls.Clear();
            Tickets = await ticketService.GetAll();

            if (Tickets != null && Tickets.Any())
            {
                TicketControl ticketControl = new TicketControl(Tickets);

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

    }
}
