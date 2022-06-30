using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
	{
		Task AddProductAsync(Product product);

		Task<List<Product>> GetProductsByNameAsync(string name);

		Task<Product> GetProductByIdAsync(int productId);

        Task UpdateProductAsync(Product product);
    }
}

