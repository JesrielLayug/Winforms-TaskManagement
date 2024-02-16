using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class EmployeeTicket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TicketId { get; set; }
        public string Title { get; set; }
        public string AssignName { get; set; }
        public string Priority { get; set; }
        public string Division { get; set; }
        public string TicketStatus { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCancelled { get; set; }
        public string Request {  get; set; } // if the request is for update or create new
        public string RequestorId {  get; set; }
        public string RequestorName { get; set; }
        public DateTime DateRequestCreated { get; set; }
    }
}
