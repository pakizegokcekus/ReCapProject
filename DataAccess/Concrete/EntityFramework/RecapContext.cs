using DataAccess.ReCap.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ReCap
{
    public class RecapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\mssqllocaldb; Database = ReCap; Trusted_Connection = true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
