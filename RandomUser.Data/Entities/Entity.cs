using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Entities
{
    public class Entity : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
