using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Product
	{
		public int ProductId { get; set; }

        [Required]
		public string ProductName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to {0}")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater or equal to {0}")]
        public double Price { get; set; }

        public List<ProductInventory>? ProductInventories { get; set; }

	}
}

