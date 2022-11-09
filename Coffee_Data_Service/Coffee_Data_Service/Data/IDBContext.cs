using System;
using Coffee_Data_Service.Entities;
using MongoDB.Driver;

namespace Coffee_Data_Service.Data
{
    public interface IDBContext
    {
        IMongoCollection<Coffee> Coffee { get; }
    }
}