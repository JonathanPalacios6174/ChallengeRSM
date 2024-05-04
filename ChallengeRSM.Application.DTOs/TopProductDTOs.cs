using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRSM.Application.DTOs
{
    public class TopProductDTOs
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public int? TotalQuantity { get; set; }

        public decimal? TotalSales { get; set; }
    }
}
