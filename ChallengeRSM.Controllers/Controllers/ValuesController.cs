using ChallengeRSM.Domain.Interface.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeRSM.Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISalesReportService _salesReportService;

        public ValuesController(ISalesReportService reportService)
        {
            _salesReportService = reportService;
        }
        // GET: api/<ValuesController>
        [HttpGet]


        public async Task<IActionResult> Get()
        {

            return Ok(await _salesReportService.GetSalesReports());
        }

        
    }
}
