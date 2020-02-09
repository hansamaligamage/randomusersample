using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUser.Data.Entities
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base (options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Name> Names { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<DateConfiguration> DateConfigurations { get; set; }

        public DbSet<IdConfiguration> IdConfigurations { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<Coordinates> Coordinates { get; set; }

        public DbSet<Timezone> Timezones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(f => f.Id).ValueGeneratedOnAdd();
        }
    }
}
