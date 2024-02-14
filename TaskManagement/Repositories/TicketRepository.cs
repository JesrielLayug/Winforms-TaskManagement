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
        private readonly IMongoCollection<Ticket> TicketCollection;

        public TicketRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            TicketCollection = database.GetCollection<Ticket>("Tickets");
        }

        public async Task Add(Ticket task)
        {
           await TicketCollection.InsertOneAsync(task);
        }

        public async Task Delete(string id)
        {
            await TicketCollection.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
            return await TicketCollection.Find(x => true).ToListAsync();
        }

        public async Task Update(Ticket ticket, string id)
        {
            await TicketCollection.ReplaceOneAsync(x => x.Id == id, ticket);
        }
    }
}
