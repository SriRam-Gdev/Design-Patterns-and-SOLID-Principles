public class InternationalRateProvider : IShippingRateProvider
{
    public decimal GetRate(double weightKg) => (decimal)weightKg * 25m;
}