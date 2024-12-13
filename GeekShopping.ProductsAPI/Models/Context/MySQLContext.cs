using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductsAPI.Models.Context;

public class MySQLContext : DbContext
{
    public MySQLContext() {}

    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 4,
                Name = "Smartphone",
                Price = 1000,
                Description = "Smartphone Description",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image.jpg"
            }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 5,
                Name = "Smartphone 2",
                Price = new decimal(10.36),
                Description = "Smartphone Description 2",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image2.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 6,
                Name = "Smartphone 3",
                Price = new decimal(10.36),
                Description = "Smartphone Description 3",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image3.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 7,
                Name = "Smartphone 4",
                Price = new decimal(10.36),
                Description = "Smartphone Description 4",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image4.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 8,
                Name = "Smartphone 5",
                Price = new decimal(10.36),
                Description = "Smartphone Description 5",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image5.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 9,
                Name = "Smartphone 6",
                Price = new decimal(10.36),
                Description = "Smartphone Description 6",
                CatergoryName = "Smartphone",
                ImageUrl = "http://www.abc.com.br/image6.jpg"
            }
        );

    }
}
