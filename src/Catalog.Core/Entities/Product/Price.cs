using System.ComponentModel.DataAnnotations;

namespace Catalog.Core.Entities.Product
{
    public class Price: BaseEntity
    {
        [Required]
        public double CurrentPrice { get; set; }

        [Required]
        public bool IsPromotional { get; set; } = false;

        [Required]
        public DateOnly InitialDate { get; set; }
        
        [Required]
        public DateOnly EndDate { get; set; }
    }
}