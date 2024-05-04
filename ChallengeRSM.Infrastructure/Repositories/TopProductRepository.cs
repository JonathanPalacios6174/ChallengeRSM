using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;
using ChallengeRSM.Domain.Entities;
using ChallengeRSM.Domain.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ChallengeRSM.Infrastructure.Repositories
{
    public class TopProductRepository : ITopProductRepository
    {
        private readonly AdvWorksDbContext _dbContext;

        public TopProductRepository(AdvWorksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<vTopProducts>> GetSalesReports()
        {
            var result = await _dbContext.Set<vTopProducts>()
                .AsNoTracking()
                .Take(10)
                .ToListAsync();
            return result;
        }
    }
}
