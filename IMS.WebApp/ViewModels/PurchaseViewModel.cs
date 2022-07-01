using System.ComponentModel.DataAnnotations;
using IMS.CoreBusiness;

namespace IMS.WebApp.ViewModels
{
	public class PurchaseViewModel
	{
        [Required]
		public string PurchaseOrder { get; set; }

        [Required]
        public int InventoryId { get; set; }

        [Required]
        public string InventoryName { get; set; }

        [Required]
        [Range(minimum:1, maximum:int.MaxValue, ErrorMessage = "Quantity has to be greater than 1.")]
        public int QuantityToPurchase { get; set; }

        public double InventoryPrice { get; set; }
	}
}

