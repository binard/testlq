using Microsoft.EntityFrameworkCore;

namespace LightQueryTest.Data
{
    public class LightQueryContext : DbContext
    {
        public LightQueryContext(DbContextOptions<LightQueryContext> options) 
            : base(options)
        {

        }

        public DbSet<TableTest> TableTest { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableTest>().HasKey(t => t.Id);
        }
    }
}
