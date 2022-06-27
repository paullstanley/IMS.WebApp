using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}