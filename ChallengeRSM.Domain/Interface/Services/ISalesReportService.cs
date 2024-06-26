﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;
using ChallengeRSM.Domain.Entities;


namespace ChallengeRSM.Domain.Interface.Services
{
    public interface ISalesReportService
    {
        Task<IEnumerable<GetAllSalesReportDTOs>> GetSalesReports();
        Task<IEnumerable<TopSalesByProductCategoryDTOs>> GetProductByCategory();
    }
        
}
