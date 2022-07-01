using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
	public interface IInventoryTransactionRepository
	{
		Task PurchaseAsync(string poNumber, Inventory inventory, int quantity, double price, string doneBy);
	}
}

