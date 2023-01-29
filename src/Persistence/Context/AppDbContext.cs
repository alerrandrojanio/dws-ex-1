using Microsoft.EntityFrameworkCore;
using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder
                .Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            builder
                .Entity<Category>()
                .HasData(
                    new Category { Id = 100, Name = "Fruits and Vegetables" },
                    new Category { Id = 101, Name = "Dairy" },
                    new Category { Id = 102, Name = "Hygiene" }
                );
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuatityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();

            builder.Entity<Employee>().ToTable("Employees");
            builder.Entity<Employee>().HasKey(p => p.Id);
            builder.Entity<Employee>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Employee>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Employee>().Property(p => p.Birthday).IsRequired().HasMaxLength(30);
            builder
                .Entity<Employee>()
                .HasData(
                    new Employee
                    {
                        Id = 10,
                        Name = "Francisco",
                        Birthday = "2018-12-10T13:45:00.000Z"
                    }
                );
        }
    }
}
