using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
	{
		Task AddProductAsync(Product product);

		Task<List<Product>> GetProductsByName(string name);
        
	}
}

