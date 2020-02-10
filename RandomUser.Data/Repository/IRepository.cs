using RandomUser.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandomUser.Data.Repository
{
    public interface IRepository <T> where T : IEntity
    {

        Task Create(T entity);

        Task CreateMany(List<T> entity);

        Task<List<T>> Get();
    }
}
