namespace src.Concepts.DesignPatterns.Creational.AbstractFactory
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}