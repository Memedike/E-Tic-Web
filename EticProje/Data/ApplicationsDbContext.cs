using EticProje.Models;
using Microsoft.EntityFrameworkCore;

namespace EticProje.Data
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) : base(options)
        {

        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Products>? Products { get; set; }

    }
}
