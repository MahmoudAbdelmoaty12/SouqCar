
using Microsoft.EntityFrameworkCore;
using SouqCar.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SouqCar.Context
{
    public class SouqCarContext : IdentityDbContext<SouqCarUser>
    {
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySpecifications> CategorySpecifications { get; set; }
        public DbSet<ProductCategorySpecifications> ProductCategorySpecifications { get; set; }

        public SouqCarContext(DbContextOptions<SouqCarContext> options) : base(options)

        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
