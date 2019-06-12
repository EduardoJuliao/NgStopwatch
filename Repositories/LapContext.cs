using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularStopwatch.Repositories
{
    public class LapContext : DbContext
    {
        public DbSet<Lap> Time { get; set; }
    }
}