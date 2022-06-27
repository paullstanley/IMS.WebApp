using System;
using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
	public interface IInventoryRepository
	{
		Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
	}
}

