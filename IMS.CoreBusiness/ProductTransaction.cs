using System;
using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
	public class ProductTransaction
	{
        public int ProductTransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int QuantityBefore { get; set; }

        //Action Taken - Purchase of product
        [Required]
        public ProductTransactionType ActivityType { get; set; }

        [Required]
        public int QuantityAfter { get; set; }

        public string? ProductionNumber { get; set; }

        public string? SalesOrderNumber { get; set; }

        public double? UnitPrice { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public string DoneBy { get; set; }

        //Navigation Properties
        public Product Product { get; set; }
    }
}

