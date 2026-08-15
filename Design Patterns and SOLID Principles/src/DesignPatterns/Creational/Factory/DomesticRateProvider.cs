public class DomesticRateProvider : IShippingRateProvider
{
    public decimal GetRate(double weightKg) => (decimal)weightKg * 10m;
}