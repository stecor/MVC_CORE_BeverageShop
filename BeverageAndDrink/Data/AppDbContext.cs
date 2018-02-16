using BeverageAndDrink.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeverageAndDrink.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
