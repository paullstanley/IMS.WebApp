using IMS.UseCases.PluginInterfaces;
using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public class PurchaseInventoryUseCase : IPurchaseInventoryUseCase
    {
        private readonly IInventoryTransactionRepository inventoryTransactionRepository;
        private readonly IInventoryRepository InventoryRepository;

        public PurchaseInventoryUseCase(
            IInventoryTransactionRepository inventoryTransactionRepository,
            IInventoryRepository inventoryRepository)
        {

            this.inventoryTransactionRepository = inventoryTransactionRepository;
            this.InventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string doneBy)
        {
            await this.inventoryTransactionRepository.PurchaseAsync(poNumber, inventory, quantity, inventory.Price, doneBy);

            inventory.Quantity += quantity;
            await this.InventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}

