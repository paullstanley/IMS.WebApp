using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class ViewProductByIdUseCase : IViewProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> ExecuteAsync(int productId)
        {
            return await this.productRepository.GetProductByIdAsync(productId);
        }
    }
}

