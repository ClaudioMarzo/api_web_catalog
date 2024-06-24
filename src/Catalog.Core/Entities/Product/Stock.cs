using System.ComponentModel.DataAnnotations;

namespace Catalog.Core.Entities.Product
{
    public class Stock : BaseEntity
    {
        [Required]
        public int Quantity { get; set; }
    }
}
