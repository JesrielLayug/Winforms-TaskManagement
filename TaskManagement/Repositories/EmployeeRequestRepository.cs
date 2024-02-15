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
        private readonly IMongoCollection<EmployeeRequest> RequestCollection;

        public EmployeeRequestRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            RequestCollection = database.GetCollection<EmployeeRequest>("Requests");
        }

        public async Task Add(EmployeeRequest request)
        {
            await RequestCollection.InsertOneAsync(request);
        }

        public async Task<IEnumerable<EmployeeRequest>> GetAll(string employeeId)
        {
            return await RequestCollection.Find(x => x.RequestorId == employeeId && x.IsCancelled == false).ToListAsync();
        }

        public async Task<EmployeeRequest> GetById(string id)
        {
            return await RequestCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(EmployeeRequest request, string Id)
        {
            await RequestCollection.ReplaceOneAsync(x => x.Id == Id, request);
        }
    }
}
