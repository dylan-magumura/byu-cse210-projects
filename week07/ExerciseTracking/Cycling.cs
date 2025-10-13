using System;

namespace ExerciseTracking
{
    class Cycling : Activity
    {
        private double _speed; // mph

        public Cycling(DateTime date, int lengthMinutes, double speed)
            : base(date, lengthMinutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return _speed * (LengthMinutes / 60.0);
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }
    }
}
