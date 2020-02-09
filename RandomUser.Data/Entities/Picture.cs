using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class Picture : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
