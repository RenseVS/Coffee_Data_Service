using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Coffee_Data_Service.Entities;
using Coffee_Data_Service.Enums;
using Coffee_Data_Service.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coffee_Data_Service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StatisticController : Controller
    {
        private readonly StatisticService _statisticService;
        public StatisticController(StatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        [Route("flavor/{machineid}/{flavortype}")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Statistic>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Statistic>>> GetFlavorStatistics([FromRoute] string machineid, [FromRoute] FlavorType flavortype)
        {
            try
            {
                var result = await _statisticService.FlavorStatistic(machineid, flavortype);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                //_log.LogInformation(ex, "Problem with room retrieval by user and workspace");
                return BadRequest(ex);
            }
        }
    }
}

