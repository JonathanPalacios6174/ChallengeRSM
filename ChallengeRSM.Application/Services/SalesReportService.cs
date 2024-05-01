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

            int numberReport = 0;

            foreach(var s in saleReports)
            {
                if (numberReport <= 20)
                {
                    GetAllSalesReportDTOs dto = new() 
                    {
                        OrderId = s.OrderID,
                        ProductName = s.ProductName
                    };

                    list.Add(dto);

                    numberReport++;
                }
                else
                {
                    break;
                }
            }

            return list;
        }
    }
}
