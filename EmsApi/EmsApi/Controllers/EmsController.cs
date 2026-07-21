using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmsApi.Data;

namespace EmsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmsController : ControllerBase
    {
        private readonly EmsContext _context;

        public EmsController(EmsContext context)
        {
            _context = context;
        }

        // URL will just be: /api/ems/raw
        [HttpGet("raw")]
        public async Task<IActionResult> GetAllRawData()
        {
            var data = await _context.T_PLC_LOG_EMS
                                     .OrderBy(e => e.Id)
                                     .ThenBy(e => e.Entry_Time)
                                     .ToListAsync();
            return Ok(data);
        }

        // URL will just be: /api/ems/hourly
        [HttpGet("hourly")]
        public async Task<IActionResult> GetAllHourlyData()
        {
            var data = await _context.T_PLC_LOG_EMS_HOURLY
                                     .OrderBy(e => e.Id)
                                     .ThenBy(e => e.Entry_Time)
                                     .ToListAsync();
            return Ok(data);
        }

        // URL will just be: /api/ems/daily
        [HttpGet("daily")]
        public async Task<IActionResult> GetAllDailyData()
        {
            var data = await _context.T_PLC_LOG_EMS_DAILY
                                     .OrderBy(e => e.Id)
                                     .ThenBy(e => e.Entry_Time)
                                     .ToListAsync();
            return Ok(data);
        }

        // URL will just be: /api/ems/monthly
        [HttpGet("monthly")]
        public async Task<IActionResult> GetAllMonthlyData()
        {
            var data = await _context.T_PLC_LOG_EMS_MONTHLY
                                     .OrderBy(e => e.Id)
                                     .ThenBy(e => e.Entry_Time)
                                     .ToListAsync();
            return Ok(data);
        }

        [HttpGet("masterview")]
        public async Task<IActionResult> GetAllMasterViewData()
        {
            var data = await _context.V_EMS_MASTER_DAILY
                                     .OrderBy(e => e.Entry_Time)
                                     .ToListAsync();
            return Ok(data);
        }
    }
}