using Microsoft.EntityFrameworkCore;
using RandomUser.Data.Entities;
using RandomUser.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RandomUser.Data.Persistence
{
    public class UserPersistenceService : IUserPersistenceService
    {
        private readonly IRepository<User> _repository;
        public UserPersistenceService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task CreateUser(User user)
        {
            await _repository.Create(user);
        }

        public async Task CreateUsers(List<User> users)
        {
            await _repository.CreateMany(users);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.Get();
        }

    }
}
