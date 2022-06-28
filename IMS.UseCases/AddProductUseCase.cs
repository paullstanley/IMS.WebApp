using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository productInventory;

        public AddProductUseCase(IProductRepository productInventory)
        {
            this.productInventory = productInventory;
        }

        public async Task ExecuteAsync(Product product)
        {
            if (product == null) return;

            await productInventory.AddProductAsync(product);
        }
    }
}

