using Domain;
using System.Data.Entity;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        //Name="ProductDb" is the name of the connection setted in App.config
        public ProductDbContext() : base("Name=ProductDb")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProductDbContext>());

            //Setting Database.Initialize as false it will only be executed if it wasn't executed yet in the DbContext
            Database.Initialize(false);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
