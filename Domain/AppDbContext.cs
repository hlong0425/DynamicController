
using Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Domain
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entitiesAssembly = typeof(EntityBase).Assembly;
            modelBuilder.RegisterAllEntities<EntityBase>(entitiesAssembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}