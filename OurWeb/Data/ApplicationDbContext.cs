using Microsoft.EntityFrameworkCore;
using OurWeb.Models;

namespace OurWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
    }
}
