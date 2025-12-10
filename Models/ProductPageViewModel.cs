using Microsoft.AspNetCore.Mvc.Rendering;

namespace Storage.Models
{
    public class ProductPageViewModel
    {
        public IEnumerable<LimitedProduct> Products { get; set; }
        public string SelectedCategory { get; set; }
        public SelectList CategoryList { get; set; }
    }
}
