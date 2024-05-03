using System.ComponentModel;

namespace Web.Models
{
    public class SalesReportModel
    {
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Customer ID")]
        public int CustomerID { get; set; }

        [DisplayName("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Category")]
        public string ProductCategory { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Quantity")]
        public short Quantity { get; set; }

        [DisplayName("Total Price")]
        public decimal? TotalPrice { get; set; }

        [DisplayName("Sales Person ID")]
        public int? SalesPersonID { get; set; }

        [DisplayName("Sales Person Name")]
        public string SalesPersonName { get; set; }

        [DisplayName("Shipping Address")]
        public string ShippingAddress { get; set; }

        [DisplayName("Billing Address")]
        public string BillingAddress { get; set; }
    }
}
