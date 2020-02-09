using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Entities
{
    public interface IEntity
    {
        [JsonProperty("id")]
        int Id { get; set; }
    }
}
