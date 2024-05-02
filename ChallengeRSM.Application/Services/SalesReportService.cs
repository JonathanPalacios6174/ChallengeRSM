using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;
using ChallengeRSM.Domain.Interface.Repositories;
using ChallengeRSM.Domain.Interface.Services;
using ChallengeRSM.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ChallengeRSM.Application.Services
{
    public class SalesReportService : ISalesReportService
    {
        private readonly ISalesReportRepository _salesReportRepository;

        public SalesReportService(ISalesReportRepository salesReportRepository)
        {
            _salesReportRepository = salesReportRepository;
        }
        public async Task<IEnumerable<GetAllSalesReportDTOs>> GetSalesReports()
        {
            var saleReports = await _salesReportRepository.GetSalesReports();

            List<GetAllSalesReportDTOs> list = [];

            foreach(var s in saleReports)
            {
                    GetAllSalesReportDTOs dto = new() 
                    {
                        OrderId = s.OrderID,
                        OrderDate = s.OrderDate,
                        CustomerId = s.CustomerID,
                        ProductId = s.ProductID,
                        ProductName = s.ProductName,
                        ProductCategory = s.ProductCategory,
                        UnitPrice = s.UnitPrice,
                        Quantity = s.Quantity,
                        TotalPrice = s.TotalPrice,
                        SalesPersonId = s.SalesPersonID,
                        SalesPersonName = s.SalesPersonName,
                        ShippingAddress = s.ShippingAddress,
                        BillingAddress = s.BillingAddress

                    };

                    list.Add(dto);
            }

            return list;
        }
    }
}
