namespace Mentoring.Project04
{
    public interface IFuelTank
    {
        int Liters { get; set; }
        void Refuel(int liters);
    }
}
