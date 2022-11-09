using System;
using Coffee_Data_Service.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace Coffee_Data_Service.Entities
{
    [BsonIgnoreExtraElements]
    public class Statistic
    {
        public string? type { get; set; }
        public int? total { get; set; }
        public int Key { get; set; }
    }
}

