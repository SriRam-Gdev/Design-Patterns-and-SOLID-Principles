namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render button");
        }
    }
}