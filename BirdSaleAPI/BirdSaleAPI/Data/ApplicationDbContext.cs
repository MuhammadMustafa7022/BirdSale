using Microsoft.EntityFrameworkCore;

namespace BirdSaleAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
        }
        public DbSet<BirdCategory> birdCategories { get; set; }
    }
}
