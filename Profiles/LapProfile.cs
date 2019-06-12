using AngularStopwatch.Controllers.Entities;
using AngularStopwatch.Models;
using AutoMapper;

namespace AngularStopwatch.Profiles
{
    public class LapProfile : Profile
    {
        public LapProfile()
        {
            CreateMap<TimeModel, Lap>();
            CreateMap<Lap, TimeModel>();
        }
    }
}