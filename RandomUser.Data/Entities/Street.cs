using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class Street : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
