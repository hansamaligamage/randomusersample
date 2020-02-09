using Newtonsoft.Json;
using RandomUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RandomUser.Data.Repository.Services
{
    public class UserAPIService : IUserApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<User>> GetUsers()
        {
            List<User> users = new List<User>();
            var requestUri = "https://randomuser.me/api?exc=id&results=5";
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<Root>(result).Results;
            }
            return users;
        }
    }
} 
