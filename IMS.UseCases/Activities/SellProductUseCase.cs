using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductTransactionRepository ProductTransactionRepository;
        private readonly IProductRepository ProductRepository;

        public SellProductUseCase(
            IProductTransactionRepository ProductTransactionRepository,
            IProductRepository ProductRepository
            )
        {
            this.ProductTransactionRepository = ProductTransactionRepository;
            this.ProductRepository = ProductRepository;
        }

        public async Task ExecuteAsync(string salesOrderNumber, Product product, int quantity, string doneBy)
        {
            await this.ProductTransactionRepository.SellProductAsync(salesOrderNumber, product, quantity, product.Price, doneBy);

            product.Quantity -= quantity;
            await this.ProductRepository.UpdateProductAsync(product);
        }
    }
}

