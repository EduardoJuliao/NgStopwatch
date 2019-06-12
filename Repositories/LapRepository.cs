using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Interfaces.Repositories;
using AngularStopwatch.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularStopwatch.Repositories
{
    public class LapRepository : ILapRepository
    {
        private readonly LapContext context;

        public LapRepository(LapContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Lap>> Get(string userId)
        {
            return await context.Lap.ToListAsync();
        }

        public async Task Save(Lap model)
        {
            await context.Lap.AddAsync(model);
            await context.SaveChangesAsync();
        }
    }
}