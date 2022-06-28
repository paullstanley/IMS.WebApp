namespace IMS.CoreBusiness
{
    public class ProductInventory
	{
		public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int InventoryId { get; set; }

        public Inventory? Inventory { get; set; }

        public int InventoryQuantity { get; set; }
    }
}

