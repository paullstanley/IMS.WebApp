using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewProductByIdUseCase
    {
        Task<Product> ExecuteAsync(int productId);
    }
}