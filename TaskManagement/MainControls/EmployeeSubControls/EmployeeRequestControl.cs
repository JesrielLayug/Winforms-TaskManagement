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

namespace TaskManagement.MainControls.EmployeeSubControls
{
    public partial class EmployeeRequestControl : UserControl
    {
        private readonly IEmployeeRequestService requestService;
        
        IEnumerable<EmployeeSubRequest> Tickets;


        public EmployeeRequestControl(IEmployeeRequestService requestService)
        {
            this.requestService = requestService;

            InitializeComponent();
            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            Tickets = await requestService.GetAll();

            DGVRequests.DataSource = Tickets;

            if(DGVRequests.Rows.Count > 0)
            {
                var Ticket = (EmployeeSubRequest)DGVRequests.Rows[0].DataBoundItem;

               PopulateFields(Ticket);
            }
        }

        private void PopulateFields(EmployeeSubRequest Ticket)
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

                if(selected.DataBoundItem is EmployeeSubRequest)
                {
                    EmployeeSubRequest clickedTicket = (EmployeeSubRequest)selected.DataBoundItem;
                    PopulateFields (clickedTicket);

                    if (!TicketDetailsContainer.Controls.Contains(TicketDetails))
                    {
                        TicketDetailsContainer.Controls.Clear();
                        TicketDetailsContainer.Controls.Add(TicketDetails);
                    }
                }
            }
        }
    }
}
