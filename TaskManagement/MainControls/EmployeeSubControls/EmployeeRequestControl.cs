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
using TaskManagement.Services;
using TaskManagement.Services.Contracts;
using TaskManagement.UserControls;
using TaskManagement.Utilities;
using TaskManagement.Views;

namespace TaskManagement.MainControls.EmployeeSubControls
{
    public partial class EmployeeRequestControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;

        private ButtonClickHandler ApprovedClickHandler;


        IEnumerable<EmployeeTicketInfo> Tickets;
        EmployeeTicketInfo Ticket;

        public EmployeeRequestControl(
            IUserService userService,
            ITicketService ticketService,
            IEmployeeRequestService requestService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;

            // Handles the Button Click
            ApprovedClickHandler = new ButtonClickHandler();
            ApprovedClickHandler.ButtonClicked += ApprovedClickHandler_ButtonClicked;

            InitializeComponent();
            InitializeDataGridView();
        }

        private void ApprovedClickHandler_ButtonClicked(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            MainContainer.Controls.Clear();
            Tickets = await requestService.GetAllUserRequest();

            if(Tickets.Count() > 0 )
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
            if(DGVRequests.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = DGVRequests.SelectedRows[0];

                if(selected.DataBoundItem is EmployeeTicketInfo)
                {
                    EmployeeTicketInfo clickedTicket = (EmployeeTicketInfo)selected.DataBoundItem;
                    PopulateFields (clickedTicket);

                    if (!TicketDetailsContainer.Controls.Contains(TicketDetails))
                    {
                        TicketDetailsContainer.Controls.Clear();
                        TicketDetailsContainer.Controls.Add(TicketDetails);
                    }
                }
            }
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            TicketEditorView editor = new TicketEditorView(null, Ticket, userService, ticketService, requestService);
            editor.TicketRequestUpdated += (s, es) => { InitializeDataGridView(); }; 
            editor.ShowDialog();
        }

        private async void BTNDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Are you sure you wan't to delete this request? This can't be undone.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dialog == DialogResult.OK)
            {
                var response = await requestService.Delete(Ticket);
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
