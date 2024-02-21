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
    public class LogsRepository : ILogsRepository
    {
        private readonly IMongoClient mongoClient;
        private readonly IDatabaseSetting setting;
        private readonly IMongoCollection<UserLogs> LogsCollection;

        public LogsRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            LogsCollection = database.GetCollection<UserLogs>("Logs");
        }

        public async Task Add(UserLogs logs)
        {
            await LogsCollection.InsertOneAsync(logs);
        }

        public async Task<IEnumerable<UserLogs>> GetByUserId(string userId)
        {
            return await LogsCollection.Find(x => x.UserId == userId).ToListAsync();
        }
    }
}
