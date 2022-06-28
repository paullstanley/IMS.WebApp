using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}