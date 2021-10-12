using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CIS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
       private Services.IDashboardService _dashboardService;

        public DashboardController(Services.IDashboardService  dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int doctorID)
        {
            IEnumerable<Models.PrescriptionCount> prescriptionCounts = await _dashboardService.GetPrescriptionCount(doctorID);
            return Ok(prescriptionCounts.ToList());
        }
    }
}
