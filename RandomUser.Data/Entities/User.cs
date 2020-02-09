using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomUser.Data.Entities
{
    public class User : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("name")]
        public virtual Name Name { get; set; }
        [JsonProperty("location")]
        public virtual Location Location { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("login")]
        public virtual Login Login { get; set; }
        [JsonProperty("dob")]
        public virtual DateConfiguration Dob { get; set; }
        [JsonProperty("registered")]
        public virtual DateConfiguration Registered { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("cell")]
        public string Cell { get; set; }
        [JsonProperty("picture")]
        public virtual Picture Picture { get; set; }
    }
}
