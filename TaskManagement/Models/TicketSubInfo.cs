using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TicketSubInfo
    {
        public string Title { get; set; }
        public string AssignUserName { get; set; }
        public string TicketStatus { get; set; }
        public string Priority { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
    }
}
