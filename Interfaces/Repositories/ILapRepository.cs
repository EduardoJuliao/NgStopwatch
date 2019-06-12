using System.Collections.Generic;
using System.Threading.Tasks;
using AngularStopwatch.Models;

namespace AngularStopwatch.Interfaces.Repositories
{
    public interface ILapRepository
    {
        Task Save(TimeModel model);
        Task<IEnumerable<TimeModel>> Get(string userId);
    }
}