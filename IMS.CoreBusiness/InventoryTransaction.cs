using System;
using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
	public class InventoryTransaction
	{

		public int InventoryTransactionId { get; set; }

        [Required]
        public int InventoryId { get; set; }

        [Required]
        public int QuantityBefore { get; set; }

        //Action Taken - Purchase of product
        [Required]
        public InventoryTransactionType ActivityType { get; set; }

        [Required]
        public int QuantityAfter { get; set; }

        public string? PONumber { get; set; }

        public string? ProductionNumber { get; set; }

        public double? UnitPrice { get; set; }

        [Required]
		public DateTime TransactionDate { get; set; }

        [Required]
        public string DoneBy { get; set; }

        //Navigation Properties
		public Inventory Inventory { get; set; }
	}
}

