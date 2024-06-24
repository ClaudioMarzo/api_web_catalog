using System.ComponentModel.DataAnnotations;

namespace Catalog.Core.Entities.Customer
{
    public class Customer : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }
    }
}
