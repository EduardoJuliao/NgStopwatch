using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularStopwatch.Repositories
{

    public class LapContext : DbContext
    {
        public LapContext(DbContextOptions<LapContext> options)
            : base(options)
        {

        }

        public DbSet<Lap> Lap { get; set; }
    }
}