using FitnessApp.Activities;

namespace FitnessApp.DerivedActivities
{
    // Derived class for Running
    public class Running : Activity
    {
        private double _distance; // Distance in miles

        public Running(string date, int durationMinutes, double distance) : base(date, durationMinutes)
        {
            _distance = distance;
        }

        public override double GetDistance() => _distance;

        public override double GetSpeed()
        {
            // Speed = distance (miles) / time (hours)
            return (_distance / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            // Pace = time (minutes) / distance (miles)
            return DurationMinutes / _distance;
        }
    }
}
