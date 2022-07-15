using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<List<Inventory>> ExecuteAsync(string name = "");
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}