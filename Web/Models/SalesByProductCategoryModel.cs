using System.ComponentModel;

namespace Web.Models
{
    public class SalesByProductCategoryModel
    {
        [DisplayName("Product Category")]
        public string ProductCategory { get; set; }

        [DisplayName("Total Price")]
        public decimal? TotalPrice { get; set; }
    }
}
 