namespace Vehicles
{
    public interface IVehicleCostCalculator
    {
        decimal BaseCost { get; }
        decimal CalculateCost(IVehicle vehicle);
    }
}
