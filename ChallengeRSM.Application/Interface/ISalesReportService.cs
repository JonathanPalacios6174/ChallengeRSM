using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;

namespace ChallengeRSM.Application.Interface
{
    public interface ISalesReportService
    {
        Task<IEnumerable<SalesReport>> GetSalesReports();
    }
}
