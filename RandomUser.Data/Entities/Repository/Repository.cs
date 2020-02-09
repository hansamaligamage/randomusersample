using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RandomUser.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly UserDbContext _context;
        private readonly ILogger _logger;

        public Repository(UserDbContext context, ILogger<Repository<T>> loggger)
        {
            _context = context;
            _logger = loggger;
        }

        public async Task Create(T entity)
        {
            if (entity != null)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task CreateMany(List<T> entity)
        {
            if (entity != null)
            {
                await _context.AddRangeAsync(entity);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError("Error saving data", ex);
                    throw new Exception("Error saving data", ex);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw;
                }
            }
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
