using System;

namespace ExerciseTracking
{
    abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public DateTime Date => _date;
        public int LengthMinutes => _lengthMinutes;

        public abstract double GetDistance();  // miles or km
        public abstract double GetSpeed();     // mph or kph
        public abstract double GetPace();      // min per mile or min per km

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthMinutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
        }
    }
}
