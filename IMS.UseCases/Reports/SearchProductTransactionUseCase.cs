using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Reports
{
    public class SearchProductTransactionUseCase : ISearchProductTransactionUseCase
    {
        private readonly IProductTransactionRepository productTransactionRepository;

        public SearchProductTransactionUseCase(IProductTransactionRepository productTransactionRepository)
        {
            this.productTransactionRepository = productTransactionRepository;
        }

        public async Task<IEnumerable<ProductTransaction>> ExecuteAsync(
            string productName,
            DateTime? dateFrom,
            DateTime? dateTo,
            ProductTransactionType? transactionType)
        {
            return await this.productTransactionRepository.GetProductTransactionsAsync(
                productName,
                dateFrom,
                dateTo,
                transactionType);
        }
    }
}

