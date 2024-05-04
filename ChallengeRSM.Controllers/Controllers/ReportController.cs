using ChallengeRSM.Application.Services;
using ChallengeRSM.Domain.Interface.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeRSM.Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ISalesReportService _salesReportService;
        private readonly ITopProductService _topProductService;

        public ReportController(ISalesReportService reportService, ITopProductService topProductService)
        {
            _salesReportService = reportService;
            _topProductService = topProductService;
        }


        // GET: api/<ValuesController>
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _salesReportService.GetSalesReports());
        }

        [HttpGet("GetTopProductByCategory")]
        public async Task<IActionResult> GetTopProductByCategory()
        {

            return Ok(await _salesReportService.GetProductByCategory());
        }

        
    }
}
