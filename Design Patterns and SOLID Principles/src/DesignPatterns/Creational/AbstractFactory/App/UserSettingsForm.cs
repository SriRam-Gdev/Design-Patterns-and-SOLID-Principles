namespace src.Concepts.DesignPatterns.Creational.AbstractFactory
{

    public class UserSettingsForm
    {
        // Polymorphism used here, so that this client requires no knowledge of specific uiComponentFactory.
        public void Render(IUIComponentFactory uiComponentFactory)
        {
            uiComponentFactory.CreateButton().Render();
            uiComponentFactory.CreateCheckbox().Render();
        }
    }
}