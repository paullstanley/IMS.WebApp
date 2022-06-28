using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class ProductRepository : IProductRepository
	{
        private readonly IMSContext db;

		public ProductRepository(IMSContext db)
		{
            this.db = db;
		}

        public async Task AddProductAsync(Product product)
        {
            if (db.Products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase))) return;
            {
                db.Products.Add(product);
                await db.SaveChangesAsync();
            }
            
        }

        public async Task<List<Product>> GetProductsByName(string name)
        {
            return await this.db.Products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                                                  string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}

