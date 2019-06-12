using Newtonsoft.Json;

namespace AngularStopwatch.Models
{
    public class TimeModel
    {
        public int Milliseconds { get; set; }

        public int Seconds { get; set; }

        public int Minutes { get; set; }

        public int Hours { get; set; }

        public int Days { get; set; }
    }
}