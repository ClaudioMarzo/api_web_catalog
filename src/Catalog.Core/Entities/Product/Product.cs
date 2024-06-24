using System.ComponentModel.DataAnnotations;

namespace Catalog.Core.Entities.Product
{
    public class Product : BaseEntity
    {
        [Required]
        public byte[]? Image { get; set; }
        
        [Required]
        public string? Description { get; set; }

        [Required]
        public string? LongDescription { get; set; }

        [Required]
        public bool IsRented { get; set; } = false;

        private ProductType _productType;
        
        [Required]
        public ProductType ProductType
        {
            get => _productType;
            set
            {
                if (!Enum.IsDefined(typeof(ProductType), value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid product type.");
                }
                _productType = value;
            }
        }

        public List<Price>? Prices { get; set; }

        public List<Stock>? Stocks { get; set; }
    }
}

public enum ProductType
{
    KIT,
    SINGLE
}
