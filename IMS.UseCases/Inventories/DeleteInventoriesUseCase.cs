using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class DeleteInventoriesUseCase : IDeleteInventoriesUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public DeleteInventoriesUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(int inventoryId)
        {
            await inventoryRepository.DeleteInventoryAsync(inventoryId);
        }
    }
}

