using DesignPatterns.Creational.Builder.Components;

var director = new Director();

// ===============================
// Build a Sports Car
// ===============================

var carBuilder = new CarBuilder();

director.ConstructSportsCar(carBuilder);

var sportsCar = carBuilder.GetCar();

Console.WriteLine("===== SPORTS CAR =====");
Console.WriteLine($"Type: {sportsCar.Type}");
Console.WriteLine($"Seats: {sportsCar.Seats}");
Console.WriteLine($"Convertible: {sportsCar.isConvertible}");
Console.WriteLine($"Wheel Size: {sportsCar.Wheels.GetDiameterInInches()} inches");


// ===============================
// Build a Sports Car Manual
// ===============================

var manualBuilder = new CarManualBuilder();

director.ConstructSportsCar(manualBuilder);

Manual sportsCarManual = manualBuilder.GetManual();

Console.WriteLine();
Console.WriteLine("===== SPORTS CAR MANUAL =====");
Console.WriteLine(sportsCarManual.Print());