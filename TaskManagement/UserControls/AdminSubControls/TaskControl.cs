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
    public partial class TaskControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;

        public TaskControl(
            IUserService userService,
            ITicketService ticketService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;

            InitializeComponent();
            InitializeDataGridView();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            TicketEditorView create = new TicketEditorView(userService, ticketService);
            create.ShowDialog();
        }

        private async void InitializeDataGridView()
        {
            Container.Controls.Clear();

            var tickets = await ticketService.GetAll();

            List<TicketSubInfo> dataSource = new List<TicketSubInfo>();

            if(tickets.Count() > 0)
            {
                foreach(var ticket in tickets)
                {
                    dataSource.Add(new TicketSubInfo
                    {
                        Title = ticket.Title,
                        AssignUserName = ticket.AssignUserName,
                        Priority = ticket.Priority,
                        StartDate = ticket.StartDate,
                        DueDate = ticket.DueDate,
                        TicketStatus = ticket.TicketStatus,
                    });
                }

                DGVMain.DataSource = dataSource;
                DGVMain.Dock = DockStyle.Fill;
                DGVMain.Visible = true;
                Container.Controls.Add(DGVMain);
            }
            else
            {
                NoItemContainer.Dock = DockStyle.Fill;
                NoItemContainer.Visible = true;
                Container.Controls.Add(NoItemContainer);
            }

        }

        //private async Task<DataTable> ConvertToDataTable(IEnumerable<TicketInfo> tickets)
        //{
        //    DataTable dataTable = new DataTable();

        //    foreach(var ticket in tickets )
        //    {
        //        dataTable.Rows.Add(ticket.Title, ticket.AssignUserName, ticket.TicketStatus, ticket.Priority,
        //            ticket.StartDate, ticket.DueDate);
        //    }

        //    return dataTable;

        //}
    }
}
