using System;
using System.ComponentModel.DataAnnotations;
using Coffee_Data_Service.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coffee_Data_Service.DTOs
{
    public class CoffeeDTO
    {
        [Required]
        public string MachineID { get; set; }
        [Required]
        public DateTime BrewDate { get; set; } = DateTime.Now;

        public int? CoffeeGrams { get; set; }
        public CoffeeType? CoffeeType { get; set; }

        public int? MilkMililiter { get; set; }
        public MilkType? MilkType { get; set; }

        [Required]
        public int WaterMililiter { get; set; }

        public int? SugarGrams { get; set; }

        public int? FlavorGrams { get; set; }
        public FlavorType? FlavorType { get; set; }
    }
}

