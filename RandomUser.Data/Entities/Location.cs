using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class Location : IEntity
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("street")]
        public virtual Street Street { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("postcode")]
        public string Postcode { get; set; }
        [JsonProperty("coordinates")]
        public virtual Coordinates Coordinates { get; set; }
        [JsonProperty("timezone")]
        public virtual Timezone Timezone { get; set; }
    }
}
