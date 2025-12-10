using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Produc.Name must be at least 5 and no more than 30 characters"), MinLength(5)]
        public string Name { get; set; } = "noName";

        [Required]
        public int Price { get; set; }
        public int Count { get; set; }

        [DisplayName("Total Inventory Value")]
        public int InventoryValue { get; set; }
    }
}
