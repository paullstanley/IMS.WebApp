using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
	{
		Task<Inventory?> GetInventoryByIdAsync(int inventoryId);

		Task UpdateInventoryAsync(Inventory inventory);

		Task AddInventoryAsync(Inventory inventory);

		Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
	}
}

