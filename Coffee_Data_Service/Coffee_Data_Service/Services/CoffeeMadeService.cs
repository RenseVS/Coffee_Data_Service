using System;
using Coffee_Data_Service.Data;
using Coffee_Data_Service.Entities;

namespace Coffee_Data_Service.Services
{
    public class CoffeeMadeService
    {
        private readonly IDBContext _context;
        public CoffeeMadeService(IDBContext context)
        {
            _context = context;
        }

        public async void AddCoffee(Coffee coffee) {
            await _context.Coffee.InsertOneAsync(coffee);
        }
    }
}

