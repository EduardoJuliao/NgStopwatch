using System.Collections.Generic;
using System.Threading.Tasks;
using AngularStopwatch.Interfaces.Repositories;
using AngularStopwatch.Models;

namespace AngularStopwatch.Repositories
{
    public class LapRepository : ILapRepository
    {
        public async Task<IEnumerable<TimeModel>> Get(string userId)
        {
            return null;
        }

        public async Task Save(TimeModel model)
        {
            await Task.Run(() => { });
        }
    }
}