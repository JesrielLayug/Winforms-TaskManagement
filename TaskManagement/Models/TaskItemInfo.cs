using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TaskItemInfo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string AssignUserId { get; set; }
        public string AssignUserName {  get; set; }
        public string AssignRole {  get; set; }
        public string Priority { get; set; }
        public string Division { get; set; }
        public string TaskStatus { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public string Description { get; set; }
        public bool IsApprove {  get; set; }
        public bool IsDeleted {  get; set; }
        public string CreatedBy { get; set; }
        public string UserFullName { get; set; }
        public string UserRole {  get; set; }
    }
}
