public class EURateProvider : IShippingRateProvider
{
    public decimal GetRate(double weightKg) => (decimal)weightKg * 15m;
}