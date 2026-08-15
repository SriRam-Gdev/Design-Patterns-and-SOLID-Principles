public abstract class ShippingCostCalculator
{
    protected abstract IShippingRateProvider CreateRateProvider();

    public decimal CalculateCost(double weightKg)
    {
        var provider = CreateRateProvider();
        return provider.GetRate(weightKg);
    }
}