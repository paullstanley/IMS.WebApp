using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness.Validations
{
    internal class Product_EnsurePriceIsGreaterThanInventoriesPrice: ValidationAttribute
	{
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var product = validationContext.ObjectInstance as Product;
            if (product != null)
            {
                if (!product.ValidatePricing())
                    return new ValidationResult($"The product's price is less than the sum of its inventories' price: {product.TotalInventoryCost() } !.",
                        new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }
}

