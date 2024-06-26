﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;
using ChallengeRSM.Domain.Entities;

namespace ChallengeRSM.Domain.Interface.Repositories
{
    public interface ITopProductRepository
    {
        Task<IEnumerable<vTopProducts>> GetSalesReports();
    }
}
