using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }

        public DbSet<ProductTransaction> ProductTransaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Building Relationships
            modelBuilder.Entity<ProductInventory>()
                .HasKey(pi => new { pi.ProductId, pi.InventoryId });

            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductInventories)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Inventory)
                .WithMany(i => i.ProductInventories)
                .HasForeignKey(pi => pi.InventoryId);


			//seeding data
			modelBuilder.Entity<Inventory>().HasData(
				new Inventory {
                    InventoryId = 1,
                    InventoryName = "Gas Engine",
                    Price = 1000,
				    Quantity = 1
                },
                new Inventory {
                    InventoryId = 2,
                    InventoryName = "Body",
                    Price = 400,
				    Quantity = 1
                },
                new Inventory {
                    InventoryId = 3,
                    InventoryName = "Wheels",
                    Price = 100,
                    Quantity = 4
                },
                new Inventory {
                    InventoryId = 4,
                    InventoryName = "Seats",
                    Price = 50,
                    Quantity = 5
                },
                new Inventory
                {
                    InventoryId = 5,
                    InventoryName = "Electric Engine",
                    Price = 8000,
                    Quantity = 2
                },
                new Inventory
                {
                    InventoryId = 6,
                    InventoryName = "Battery",
                    Price = 400,
                    Quantity = 5
                });

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    ProductId = 1,
                    ProductName = "Gas Car",
                    Price = 20000,
                    Quantity = 1
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Electric car",
                    Price = 15000,
                    Quantity = 1
                });

            modelBuilder.Entity<ProductInventory>().HasData(
                //Engine
                new ProductInventory
                {
                    ProductId = 1,
                    InventoryId = 1,
                    InventoryQuantity = 1
                },
                //Body
                new ProductInventory
                {
                    ProductId = 1,
                    InventoryId = 2,
                    InventoryQuantity = 1
                },
                // 4 Wheels
                new ProductInventory
                {
                    ProductId = 1,
                    InventoryId = 3,
                    InventoryQuantity = 4
                },
                //5 Seats
                new ProductInventory
                {
                    ProductId = 1,
                    InventoryId = 4, 
                    InventoryQuantity = 5 
                });

            modelBuilder.Entity<ProductInventory>().HasData(
                //Engine
                new ProductInventory
                {
                    ProductId = 2,
                    InventoryId = 5,
                    InventoryQuantity = 1
                },
                //Body
                new ProductInventory
                {
                    ProductId = 2,
                    InventoryId = 2,
                    InventoryQuantity = 1
                },
                // 4 Wheels
                new ProductInventory
                {
                    ProductId = 2,
                    InventoryId = 3,
                    InventoryQuantity = 4
                },
                //5 Seats
                new ProductInventory
                {
                    ProductId = 2,
                    InventoryId = 4,
                    InventoryQuantity = 5
                },
                //Battery
                new ProductInventory
                {
                    ProductId = 2,
                    InventoryId = 6,
                    InventoryQuantity = 1
                });
        }
    }
}

