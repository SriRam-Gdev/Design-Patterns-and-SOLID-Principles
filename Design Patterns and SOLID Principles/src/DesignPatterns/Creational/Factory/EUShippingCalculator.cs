public class EUShippingCalculator : ShippingCostCalculator
{
    protected override IShippingRateProvider CreateRateProvider()
        => new EURateProvider();
}