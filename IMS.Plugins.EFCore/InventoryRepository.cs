using IMS.UseCases.PluginInterfaces;
using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSContext db;

        public InventoryRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task<List<Inventory>> GetInventoriesByName(string name)
        {
            return await db.Inventories.Where(x => x.InventoryName.ToLower().IndexOf(name.ToLower()) >= 0 ||
                                                    string.IsNullOrWhiteSpace(name) &&
                                                    x.IsActive == true).ToListAsync();
        }

        public async Task<Inventory?> GetInventoryByIdAsync(int inventoryId)
        {
            return await db.Inventories.FindAsync(inventoryId);
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            //To prevent different inventories from having the same name
            if (db.Inventories.Any(x => x.InventoryName.ToLower() == inventory.InventoryName.ToLower())) return;

            db.Inventories.Add(inventory);
            await db.SaveChangesAsync();
        }

        public async Task DeleteInventoryAsync(int inventoryId)
        {
            var inventory = await db.Inventories.FindAsync(inventoryId);

            if (inventory != null)
            {
                db.Remove(inventory);
                await db.SaveChangesAsync();
            }
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            if (db.Inventories.Any(x => x.InventoryId != inventory.InventoryId &&
            x.InventoryName.ToLower() == inventory.InventoryName.ToLower())) return;

            var inv = await this.db.Inventories.FindAsync(inventory.InventoryId);
            if (inv != null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Price = inventory.Price;
                inv.Quantity = inventory.Quantity;

                await db.SaveChangesAsync();
            }
        }
    }
}