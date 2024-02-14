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
    public class UserRepository : IUserRepository
    {
        private readonly IMongoClient mongoClient;
        private readonly IDatabaseSetting setting;
        private readonly IMongoCollection<User> UserCollection;

        public UserRepository(IMongoClient mongoClient, IDatabaseSetting setting)
        {
            this.mongoClient = mongoClient;
            this.setting = setting;

            var database = mongoClient.GetDatabase("TaskManagement");
            UserCollection = database.GetCollection<User>("Users");
        }

        public async Task Add(User user)
        {
            await UserCollection.InsertOneAsync(user);
        }

        public async Task Delete(string id)
        {
            await UserCollection.DeleteOneAsync(x => x.Id == id);
        }

        public async Task Update(User user, string id)
        {
            await UserCollection.ReplaceOneAsync(x => x.Id == id, user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await UserCollection.Find(x => true).ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            var user =  await UserCollection.Find(x => x.Email == email).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetById(string id)
        {
            var user = await UserCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetByName(string name)
        {
            var user = await UserCollection.Find(x => x.FullName == name).FirstOrDefaultAsync();
            return user;
        }

    }
}
