namespace IMS.UseCases
{
    public interface IDeleteInventoriesUseCase
    {
        Task ExecuteAsync(int inventoryId);
    }
}