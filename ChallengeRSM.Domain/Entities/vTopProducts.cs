using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRSM.Domain.Entities
{
    public class vTopProducts
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public int? TotalQuantity { get; set; }

        public decimal? TotalSales { get; set; }
    }
}
