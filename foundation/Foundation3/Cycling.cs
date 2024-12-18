using FitnessApp.Activities;

namespace FitnessApp.DerivedActivities
{
    // Derived class for Cycling
    public class Cycling : Activity
    {
        private double _speed; // Speed in miles per hour

        public Cycling(string date, int durationMinutes, double speed) : base(date, durationMinutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            // Distance = speed (miles per hour) * time (hours)
            return (_speed * DurationMinutes) / 60;
        }

        public override double GetSpeed() => _speed;

        public override double GetPace()
        {
            // Pace = 60 / speed (minutes per mile)
            return 60 / _speed;
        }
    }
}
