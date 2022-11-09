using System;
using Coffee_Data_Service.DTOs;
using Coffee_Data_Service.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coffee_Data_Service.Entities
{
    [BsonIgnoreExtraElements]
    public class Coffee
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string machineID { get; set; }
        public int brewYear { get; set; }
        public int brewMonth { get; set; }

        [BsonIgnoreIfNull]
        public int? coffeeGrams { get; set; }
        [BsonIgnoreIfNull]
        public CoffeeType? coffeeType { get; set; }

        [BsonIgnoreIfNull]
        public int? milkMililiter { get; set; }
        [BsonIgnoreIfNull]
        public MilkType? milkType { get; set; }

        public int waterMililiter { get; set; }

        [BsonIgnoreIfNull]
        public int? sugarGrams { get; set; }

        [BsonIgnoreIfNull]
        public int? flavorGrams { get; set; }
        [BsonIgnoreIfNull]
        public string? flavorType { get; set; }

        public Coffee(CoffeeDTO coffee)
        {
            machineID = coffee.MachineID;
            brewYear = coffee.BrewDate.Year;
            brewYear = coffee.BrewDate.Month;
            coffeeGrams = coffee.CoffeeGrams;
            coffeeType = coffee.CoffeeType;
            milkMililiter = coffee.MilkMililiter;
            milkType = coffee.MilkType;
            waterMililiter = coffee.WaterMililiter;
            sugarGrams = coffee.SugarGrams;
            flavorGrams = coffee.FlavorGrams;
            flavorType = coffee.FlavorType.ToString();
        }
    }
}

