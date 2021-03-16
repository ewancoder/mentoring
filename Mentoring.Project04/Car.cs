namespace Mentoring.Project04
{
    public sealed class Car
    {
        private readonly IFuelTank _fuelTank;

        public Car(IFuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public int Drive()
        {
            if (_fuelTank.Liters == 0)
                return 0;

            if (_fuelTank.Liters >= 20)
            {
                _fuelTank.Liters--;
                return 10;
            }

            _fuelTank.Liters--;
            return 8;
        }
    }
}
