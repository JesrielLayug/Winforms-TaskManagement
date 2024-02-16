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
    public class EmployeeRequestRepository : IEmployeeRequestRepository
    {
        private readonly IMongoClient mongoClient;
        private readonly IDatabaseSetting setting;
        private readonly IMongoCollection<EmployeeTicket> RequestCollection;

        public EmployeeRequestRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            RequestCollection = database.GetCollection<EmployeeTicket>("Requests");
        }

        public async Task Add(EmployeeTicket request)
        {
            await RequestCollection.InsertOneAsync(request);
        }

        public async Task Delete(string id)
        {
            await RequestCollection.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<EmployeeTicket>> GetAllUserRequest(string employeeId)
        {
            return await RequestCollection.Find(x => x.RequestorId == employeeId && x.IsCancelled == false && x.IsApproved == false).ToListAsync();
        }

        public async Task<IEnumerable<EmployeeTicket>> GetAll()
        {
            return await RequestCollection.Find(x => x.IsCancelled == false && x.IsApproved == false).ToListAsync();
        }


        public async Task<EmployeeTicket> GetById(string id)
        {
            return await RequestCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(EmployeeTicket request, string Id)
        {
            await RequestCollection.ReplaceOneAsync(x => x.Id == Id, request);
        }

        public async Task<IEnumerable<EmployeeTicket>> GetAllApproved()
        {
            return await RequestCollection.Find(x => x.IsApproved).ToListAsync();
        }
    }
}
