using src.Concepts.DesignPatterns.Creational.AbstractFactory;
using src.Concepts.DesignPatterns.Creational.AbstractFactory.Windows;
var UserSettingsFormUserSettingsForm = new UserSettingsForm();

UserSettingsFormUserSettingsForm.Render(new WindowsUIComponentFactory());
