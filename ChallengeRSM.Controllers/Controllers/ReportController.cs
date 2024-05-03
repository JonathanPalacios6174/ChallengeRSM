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

        public ReportController(ISalesReportService reportService)
        {
            _salesReportService = reportService;
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
