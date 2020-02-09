using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class IdConfiguration : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
