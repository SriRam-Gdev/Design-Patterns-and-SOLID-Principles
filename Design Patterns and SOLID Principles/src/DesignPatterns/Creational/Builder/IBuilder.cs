namespace DesignPatterns.Creational.Builder.Components
{
    public interface IBuilder
    {
        void Reset();
        IBuilder SetCarType(CarType type);
        IBuilder SetSeats(int seats);
        IBuilder IsConvertible(bool isConvertible);
        IBuilder SetEngine(Engine engine);
        IBuilder SetWheels(Wheels wheels);
        IBuilder SetDashboard(Dashboard dashboard);
        IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
        void BuildCarType(CarType sports);
    }
}