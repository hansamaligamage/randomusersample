using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class Timezone : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("offset")]
        public string Offset { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
