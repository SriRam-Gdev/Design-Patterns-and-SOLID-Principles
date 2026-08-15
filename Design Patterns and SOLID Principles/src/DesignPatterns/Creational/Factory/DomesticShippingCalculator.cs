public class DomesticShippingCalculator : ShippingCostCalculator
{
    protected override IShippingRateProvider CreateRateProvider()
        => new DomesticRateProvider();
}