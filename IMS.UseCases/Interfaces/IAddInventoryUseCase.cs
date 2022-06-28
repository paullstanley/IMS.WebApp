using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}