using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Entities
{

    public class Root : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("results")]
        public virtual List<User> Results { get; set; }
    }
}
