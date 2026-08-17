ShippingCostCalculator calc = new EUShippingCalculator();
decimal cost = calc.CalculateCost(20);
Console.WriteLine(cost);