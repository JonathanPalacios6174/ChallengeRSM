﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRSM.Domain.Entities
{
    public class vSalesReport
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public decimal? TotalPrice { get; set; }

        public int? SalesPersonID { get; set; }

        public string SalesPersonName { get; set; }

        public string ShippingAddress { get; set; }

        public string BillingAddress { get; set; }
    }
}
