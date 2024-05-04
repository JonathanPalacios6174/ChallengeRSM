using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeRSM.Application.DTOs;
using ChallengeRSM.Domain.Entities;
using ChallengeRSM.Domain.Interface.Repositories;
using ChallengeRSM.Domain.Interface.Services;

namespace ChallengeRSM.Application.Services
{
    public class TopProductService : ITopProductService
    {
        private readonly ITopProductRepository _topProductRepository;

        public TopProductService(ITopProductRepository topProductRepository)
        {
            _topProductRepository = topProductRepository;
        }

        public async Task<IEnumerable<TopProductDTOs>> GetTopProductReport()
        {
            var topProduct = await _topProductRepository.GetSalesReports();


            List<TopProductDTOs> list = [];

            foreach (var topProductDTO in topProduct)
            {
                TopProductDTOs oTopProductDTO = new TopProductDTOs
                {
                    ProductID = topProductDTO.ProductID,
                    ProductName = topProductDTO.ProductName,
                    ProductCategory = topProductDTO.ProductCategory,
                    TotalQuantity = topProductDTO.TotalQuantity,
                    TotalSales = topProductDTO.TotalSales,
                };

                list.Add(oTopProductDTO);
            }

            return list;
        }


    }
}
