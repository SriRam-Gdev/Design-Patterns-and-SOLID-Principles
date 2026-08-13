using src.DesignPatterns.Creational.Prototype;

var circle = new Circle { };

circle.Radius = 5;
circle.Draw();

var rectangle = new Rectangle { };
rectangle.Width = 10;
rectangle.Height = 20;
rectangle.Draw();

var shapeActions = new ShapeActions();
var duplicatedCircle = shapeActions.DuplicateShape(circle);
var duplicatedRectangle = shapeActions.DuplicateShape(rectangle);
duplicatedCircle.Draw();
duplicatedRectangle.Draw();