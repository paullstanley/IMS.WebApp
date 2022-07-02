using IMS.UseCases.PluginInterfaces;
using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public class PurchaseInventoryUseCase : IPurchaseInventoryUseCase
    {
        private readonly IInventoryTransactionsRepository inventoryTransactionsRepository;
        private readonly IInventoryRepository InventoryRepository;

        public PurchaseInventoryUseCase(
            IInventoryTransactionsRepository inventoryTransactionRepository,
            IInventoryRepository inventoryRepository)
        {

            this.inventoryTransactionsRepository = inventoryTransactionRepository;
            this.InventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string doneBy)
        {
            await this.inventoryTransactionsRepository.PurchaseAsync(poNumber, inventory, quantity, inventory.Price, doneBy);

            inventory.Quantity += quantity;
            await this.InventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}

