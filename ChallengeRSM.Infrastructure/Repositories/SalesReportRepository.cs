using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ChallengeRSM.Domain.Interface.Repositories;

namespace ChallengeRSM.Infrastructure.Repositories
{
    public class SalesReportRepository : ISalesReportRepository
    {
        private readonly AdvWorksDbContext _dbContext;

        public SalesReportRepository(AdvWorksDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<vSalesReport>> GetSalesReports()
        {
           
            return await _dbContext.Set<vSalesReport>()
                .AsNoTracking()
                .Take(10)
                .ToListAsync();
        }

        public async Task<List<vSalesReport>> GetTopProductByCategory()
        {
            var topSalesByCategory = await  _dbContext.Set<vSalesReport>()
                .GroupBy(s => s.ProductCategory)
                .Select(g => new vSalesReport
                {
                    ProductCategory = g.Key,
                    TotalPrice = g.Sum(s => s.TotalPrice)
                })
                .OrderByDescending(g => g.TotalPrice)
                .Take(7)
                .ToListAsync();

            return topSalesByCategory;
            
        }

        public async Task<IEnumerable<vSalesReport>> GetSalesReport()
        {
            var topProducts = await _dbContext.Set<vSalesReport>()
                            .GroupBy(s => new { s.ProductID, s.ProductName })
                            .Select(g => new vSalesReport
                            {
                                ProductID = g.Key.ProductID,
                                ProductName = g.Key.ProductName,
                                Quantity = ((short)g.Sum(s => s.Quantity))  // Aquí usamos Quantity en lugar de TotalQuantitySold
                            })
                            .OrderByDescending(g => g.Quantity)  // Ordenamos por Quantity
                            .Take(10)
                            .ToListAsync();

            return null;
        }
    }
    
}
