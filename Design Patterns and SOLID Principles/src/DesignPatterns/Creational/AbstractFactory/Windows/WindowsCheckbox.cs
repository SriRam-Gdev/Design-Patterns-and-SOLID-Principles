namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render checkbox");
        }
    }
}