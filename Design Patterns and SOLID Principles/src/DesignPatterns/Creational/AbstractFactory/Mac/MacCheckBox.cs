namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render checkbox");
        }
    }
}