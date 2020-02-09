using RandomUser.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandomUser.Data.Persistence
{
    public interface IUserPersistenceService
    {
        Task CreateUser(User user);

        Task CreateUsers(List<User> users);

        Task<IEnumerable<User>> GetUsers();
        
    }
}
