using CslAppSoftDelete.Maps;
using CslAppSoftDelete.Models;
using Microsoft.EntityFrameworkCore;

namespace CslAppSoftDelete.Services
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) 
            :base(options)
        {
        }

        public DbSet<Source> Source { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<House> House { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SourceMap());
            modelBuilder.ApplyConfiguration(new PeopleMap());
            modelBuilder.ApplyConfiguration(new HouseMap());
        }
    }
}
