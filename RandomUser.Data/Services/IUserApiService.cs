using RandomUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Repository.Services
{
    public interface IUserApiService
    {
        Task<List<User>> GetUsers();
    }
}
