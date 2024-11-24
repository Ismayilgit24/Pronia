using Microsoft.EntityFrameworkCore;
using ProniaApplication.Models;

namespace ProniaApplication.DAL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) { }

        public DbSet<Slide> Slides { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductsImage> ProductsImages { get; set; }


    }
}
