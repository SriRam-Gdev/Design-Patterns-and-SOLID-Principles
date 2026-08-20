using DesignPatterns.Structural.Composite;


var box = new Box();
box.AddItem(new Keyboard());
box.AddItem(new Mouse());
var box1 = new Box();
box1.AddItem(new Keyboard());
box1.AddItem(new Mouse());
box.AddItem(box1);
var box2 = new Box();
box2.AddItem(new Keyboard());
box2.AddItem(new Mouse());
box.AddItem(box2);
Console.WriteLine($"Total Price: {box.GetPrice()}");