using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}