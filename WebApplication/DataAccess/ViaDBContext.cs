using Microsoft.EntityFrameworkCore;

namespace WebApplication.DataAccess
{
    public class ViaDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Programme> Programmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = VIA.db");
        }
        
    }

}