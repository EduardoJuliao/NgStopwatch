using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularStopwatch.Interfaces.Repositories;
using AngularStopwatch.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularStopwatch.Controllers
{
    [Route("api/[controller]")]
    public class LapController : Controller
    {
        private readonly ILapRepository repo;

        public LapController(ILapRepository repo)
        {
            this.repo = repo;
        }


        [HttpPost("")]
        public async Task<ActionResult> Save([FromBody] TimeModel model)
        {
            try
            {
                await this.repo.Save(model);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet()]
        public async Task<IEnumerable<TimeModel>> Get()
        {
            return await this.repo.Get(string.Empty);
        }
    }
}