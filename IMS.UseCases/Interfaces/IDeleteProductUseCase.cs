namespace IMS.UseCases
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(int productId);
    }
}