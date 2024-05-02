namespace ChallengeRSM.Application.DTOs
{
    public class TopProductSalesDTOs
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; }
        public int TotalQuantitySold { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
