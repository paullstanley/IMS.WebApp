using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory?> ExecuteAsync(int inventoryId);
    }
}