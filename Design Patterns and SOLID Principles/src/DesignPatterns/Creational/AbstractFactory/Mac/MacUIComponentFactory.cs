namespace src.Concepts.DesignPatterns.Creational.AbstractFactory.Mac
{

    // /Mac/MacUIComponentFactory.cs
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}