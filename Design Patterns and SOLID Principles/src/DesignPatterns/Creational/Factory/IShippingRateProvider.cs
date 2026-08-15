public interface IShippingRateProvider
{
    decimal GetRate(double weightKg);
}