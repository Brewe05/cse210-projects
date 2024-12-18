using System;

namespace FitnessApp.Activities
{
    // Abstract base class for all activities
    public abstract class Activity
    {
        // Shared attributes
        private string _date;
        private int _durationMinutes;

        public Activity(string date, int durationMinutes)
        {
            _date = date;
            _durationMinutes = durationMinutes;
        }

        // Properties
        public string Date => _date;
        public int DurationMinutes => _durationMinutes;

        // Abstract methods for calculating distance, speed, and pace
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Method to get summary of the activity
        public string GetSummary()
        {
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();
            return $"{Date} {this.GetType().Name} ({DurationMinutes} min): " +
                   $"Distance {distance:F1}, Speed: {speed:F1}, Pace: {pace:F1}";
        }
    }
}
