ShippingCostCalculator calc = new InternationalShippingCalculator();
decimal cost = calc.CalculateCost(20);
Console.WriteLine(cost);