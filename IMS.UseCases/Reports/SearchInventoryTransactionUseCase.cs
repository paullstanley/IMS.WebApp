using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Reports
{
    public class SearchInventoryTransactionUseCase : ISearchInventoryTransactionUseCase
    {
        private readonly IInventoryTransactionRepository inventoryTransactionRepository;

        public SearchInventoryTransactionUseCase(IInventoryTransactionRepository inventoryTransactionRepository)
        {
            this.inventoryTransactionRepository = inventoryTransactionRepository;

        }

        public async Task<IEnumerable<InventoryTransaction>> ExecuteAsync(
            string inventoryName,
            DateTime? dateFrom,
            DateTime? dateTo,
            InventoryTransactionType? transactionType
            )
        {
            return await this.inventoryTransactionRepository.GetInventoryTransactionsAsync(inventoryName, dateFrom, dateTo, transactionType);
        }
    }
}

