namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Windows
{
    // /Windows/WindowsUIComponentFactory.cs
    public class WindowsUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}