using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Data;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;

namespace TaskManagement.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IMongoClient mongoClient;
        private readonly IDatabaseSetting setting;
        private readonly IMongoCollection<Ticket> TaskCollection;

        public TicketRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            TaskCollection = database.GetCollection<Ticket>("Tickets");
        }

        public async Task Add(Ticket task)
        {
           await TaskCollection.InsertOneAsync(task);
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
            return await TaskCollection.Find(x => true).ToListAsync();
        }
    }
}
