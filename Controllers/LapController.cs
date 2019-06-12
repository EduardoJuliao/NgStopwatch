using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Interfaces.Repositories;
using AngularStopwatch.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularStopwatch.Controllers
{
    [Route("api/[controller]")]
    public class LapController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILapRepository repo;

        public LapController(
            IMapper mapper,
            ILapRepository repo)
        {
            this.mapper = mapper;
            this.repo = repo;
        }


        [HttpPost("")]
        public async Task<ActionResult> Save([FromBody]TimeModel model)
        {
            try
            {
                if (model == null)
                    throw new ArgumentNullException();

                var lap = mapper.Map<Lap>(model);

                await this.repo.Save(lap);
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
            var times = await this.repo.Get(string.Empty);
            return times.Select(mapper.Map<TimeModel>);
        }
    }
}