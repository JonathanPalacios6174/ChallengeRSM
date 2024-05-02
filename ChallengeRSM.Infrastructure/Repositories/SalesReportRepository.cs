﻿using System;
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
    }
    
}
