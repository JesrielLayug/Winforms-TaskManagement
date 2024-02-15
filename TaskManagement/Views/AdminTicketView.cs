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

namespace TaskManagement.Views
{
    public partial class AdminTicketView : Form
    {
        TicketInfo ticket;

        public AdminTicketView(TicketInfo ticket)
        {
            this.ticket = ticket;

            InitializeComponent();
            InitializeTexts();
        }

        private void InitializeTexts()
        {
            LBTicketName.Text = ticket.Title;
            LBPriority.Text = ticket.Priority;
            LBStartDate.Text = ticket.StartDate;
            LBDueDate.Text = ticket.DueDate;
            LBAssignee.Text = ticket.AssignUserName;
            LBDivision.Text = ticket.Division;
            LBDescription.Text = ticket.Description;
            LBStatus.Text = ticket.TicketStatus;
            LBIssuer.Text = ticket.CreatorFullName;
        }
    }
}
