using System.Collections.Generic;
using System.Threading.Tasks;
using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Models;

namespace AngularStopwatch.Interfaces.Repositories
{
    public interface ILapRepository
    {
        Task Save(Lap model);
        Task<IEnumerable<Lap>> Get(string userId);
    }
}