using System;
using Coffee_Data_Service.Data;
using Coffee_Data_Service.Entities;
using Coffee_Data_Service.Enums;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;

namespace Coffee_Data_Service.Services
{
    public class StatisticService
    {
        private readonly IDBContext _context;
        public StatisticService(IDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Statistic>> FlavorStatistic(string machineid, FlavorType flavortype)
        {
            var result1 = await _context.Coffee.Find(_ => true).ToListAsync();

            IEnumerable<Statistic> result = await _context.Coffee.Aggregate().Match(x => x.machineID == machineid && x.flavorType == flavortype.ToString())
            .Group(x => x.brewYear, g => new Statistic { Key = g.Key, total = g.Sum(x => x.flavorGrams), type = g.First().flavorType })
            .ToListAsync();
            return result;
        }
    }
}

