using System;
using Coffee_Data_Service.Entities;
using MongoDB.Driver;

namespace Coffee_Data_Service.Data
{
    public class DBContext : IDBContext
    {
        public DBContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Coffee = database.GetCollection<Coffee>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
        }

        public IMongoCollection<Coffee> Coffee { get; }
    }
}

