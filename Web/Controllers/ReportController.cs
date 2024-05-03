using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class ReportController : Controller
    {
       

        // GET: ReportController
        public ActionResult Index()
        {

            return View();
               
        }

        

        public async Task<IActionResult> Report()
        {
            HttpClient rsm = new HttpClient();

            var url = "https://localhost:7220/api/Report/GetAll";

            var httpRespond = await rsm.GetAsync(url);

            var read = await httpRespond.Content.ReadAsStringAsync();

            var sellsReportList = JsonConvert.DeserializeObject<List<SalesReportModel>>(read);

            return View(sellsReportList);

        }
       

    }
}
