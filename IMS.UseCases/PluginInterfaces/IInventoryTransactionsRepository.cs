using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
	public interface IInventoryTransactionsRepository
	{
		Task PurchaseAsync(string poNumber, Inventory inventory, int quantity, double price, string doneBy);

        Task<IEnumerable<InventoryTransaction>> GetInventoryTransactionsAsync(string inventoryName, DateTime? dateFrom, DateTime? dateTo, InventoryTransactionType? transactionType);
    }
}

