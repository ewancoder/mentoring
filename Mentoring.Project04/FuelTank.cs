using System;

namespace Mentoring.Project04
{
    public sealed class FuelTank
    {
        private readonly int _capacity;
        private int _liters;

        public FuelTank(int capacity)
        {
            _capacity = capacity;
            Liters = capacity;
        }

        public int Liters
        {
            get => _liters;
            set => _liters = Math.Min(_liters + value, _capacity);
        }

        public void Refuel(int liters)
        {
            Liters += liters;
        }
    }
}
