using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeRSM.Infrastructure
{
    public class AdvWorksDbContext : DbContext
    {
        public AdvWorksDbContext()
        {
        }
        public AdvWorksDbContext(DbContextOptions<AdvWorksDbContext> options)
            :base(options) 
        { 
        }

        public virtual DbSet<vSalesReport> SalesReport { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
