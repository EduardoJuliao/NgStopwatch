namespace AngularStopwatch.Controllers.Entities
{
    public class Lap
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public int Milliseconds { get; set; }

        public int Seconds { get; set; }

        public int Minutes { get; set; }

        public int Hours { get; set; }

        public int Days { get; set; }
    }
}