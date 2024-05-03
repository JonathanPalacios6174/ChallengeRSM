using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Domain.Entities;

namespace ChallengeRSM.Domain.Interface.Repositories
{
    public interface ISalesReportRepository
    {
        Task<IEnumerable<vSalesReport>> GetSalesReports();
        Task<IEnumerable<vSalesReport>> GetSalesReport();
        Task<List<vSalesReport>> GetTopProductByCategory();
    }
}
