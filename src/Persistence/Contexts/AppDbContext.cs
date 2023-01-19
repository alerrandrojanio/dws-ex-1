using Microsoft.EntityFrameworkCore;
using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Persistence.Contexts {
    public class AppDbContext : DbContext {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        protected override void onModelCreating(ModelBuilder builder) {
            base.onModelCreating(builder);

            builder.Entity<Category>()
                .ToTable("Categories");
            builder.Entity<Category>()
                .HasKey(p => p.Id);
            builder.Entity<Category>()
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Entity<Category>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);
            builder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            builder.Entity<Category>().HasData(
                new Category { 
                    Id = 100, Name = "Fruits and Vegetables"
                }, 
                new Category { 
                    Id = 101, Name = "Dairy" 
            });
            builder.Entity<Product>()
                .ToTable("Products");
            builder.Entity<Product>()
                .HasKey(p => p.Id);
            builder.Entity<Product>()
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Entity<Product>()
                .Property(p => p.QuantityInPackage)
                .IsRequired();
            builder.Entity<Product>()
                .Property(p => p.UnitOfMeasurement)
                .IsRequired();
        }

    }
}