using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}