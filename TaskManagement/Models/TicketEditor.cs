﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TicketEditor
    {
        public string Title { get; set; }
        public string AssignName { get; set; }
        public string Priority { get; set; }
        public string Division { get; set; }
        public string TicketStatus { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public string CreatedBy { get; set; } // the one who created it
    }
}
