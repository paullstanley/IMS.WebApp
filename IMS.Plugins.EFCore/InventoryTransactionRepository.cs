using IMS.UseCases.PluginInterfaces;
using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore
{
	public class InventoryTransactionRepository: IInventoryTransactionRepository
    {

		private readonly IMSContext db;

        public InventoryTransactionRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task PurchaseAsync(string poNumber, Inventory inventory, int quantity, double price, string doneBy)
        {
            this.db.InventoryTransactions.Add(new InventoryTransaction
            {
                PONumber = poNumber,
                InventoryId = inventory.InventoryId,
                QuantityBefore = inventory.Quantity,
                ActivityType = InventoryTransactionType.PurchaseInventory,
                QuantityAfter = inventory.Quantity + quantity,
                TransactionDate = DateTime.Now,
                DoneBy = doneBy,
                UnitPrice = price * quantity

            });

            await this.db.SaveChangesAsync();
        }

		
	}
}

