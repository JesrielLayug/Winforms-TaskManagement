using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string AssignUserId {  get; set; }
        public string Priority { get; set; }
        public string Division { get; set; }
        public string TicketStatus {  get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public DateTime DateCreated {  get; set; }
        public string Description {  get; set; }
        public bool IsApproved {  get; set; }
        public string CreatorId { get; set; } // this is the created by, should store the id of user
    }
}
