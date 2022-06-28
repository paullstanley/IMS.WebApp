using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewProductsByNameUseCase
    {
        Task<List<Product>> ExecuteAsync(string name = "");
    }
}