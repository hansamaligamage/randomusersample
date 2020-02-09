using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class DateConfiguration : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
    }
}
