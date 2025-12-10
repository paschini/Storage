using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Produc.Name must be at least 5 and no more than 30 characters"), MinLength(5)]
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; } = 10;

        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        public string Category { get; set; } = "Övrigt";
        public string Shelf { get; set; } = "111";
        public int Count { get; set; } = 0;

        [MaxLength(150)]
        public string Description { get; set; } = string.Empty;
    }
}
