using FitnessApp.Activities;

namespace FitnessApp.DerivedActivities
{
    // Derived class for Swimming
    public class Swimming : Activity
    {
        private int _laps; // Number of laps

        public Swimming(string date, int durationMinutes, int laps) : base(date, durationMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            // Distance = laps * 50 meters per lap (convert to miles)
            double distanceKm = _laps * 50 / 1000.0; // in kilometers
            return distanceKm * 0.62; // convert to miles
        }

        public override double GetSpeed()
        {
            // Speed = distance (miles) / time (hours)
            return (GetDistance() / DurationMinutes) * 60;
        }

        public override double GetPace()
        {
            // Pace = time (minutes) / distance (miles)
            return DurationMinutes / GetDistance();
        }
    }
}
