using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext 
    {
        public Datcontext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
