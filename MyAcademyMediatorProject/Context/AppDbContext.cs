using Microsoft.EntityFrameworkCore;
using MyAcademyMediatorProject.Entities;

namespace MyAcademyMediatorProject.Context
{
    public class AppDbContext(DbContextOptions options):DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
