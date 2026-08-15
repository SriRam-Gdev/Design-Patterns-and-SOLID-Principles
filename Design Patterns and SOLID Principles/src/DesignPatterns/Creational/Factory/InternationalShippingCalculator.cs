public class InternationalShippingCalculator : ShippingCostCalculator
{
    protected override IShippingRateProvider CreateRateProvider()
        => new InternationalRateProvider();
}