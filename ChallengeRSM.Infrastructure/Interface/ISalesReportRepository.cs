using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Infrastructure.Models;

namespace ChallengeRSM.Infrastructure.Interface
{
    public interface ISalesReportRepository
    {
        Task<IEnumerable<vSalesReport>> GetSalesReports();
       
    }
}
