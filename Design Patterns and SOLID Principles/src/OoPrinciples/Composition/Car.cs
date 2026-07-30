public class Car
{
    private Engine engine = new Engine();
    private Wheel wheel = new Wheel();
    private Seat seat = new Seat();

    public void StartCar()
    {
        engine.Start();
        wheel.Rotate();
        seat.Adjust();
        Console.WriteLine("Car is starting.");
    }
}