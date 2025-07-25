// See https://aka.ms/new-console-template for more information
using Abstraction;

Console.WriteLine("----------------------------");
Console.WriteLine("------ABSTRACTION-----------");

var animal = new Dog();
animal.Eat();
animal.MakeSound();

/*var bird = new Bird();
bird.Eat();*/



Console.WriteLine("------Shape examples-----------");
var square = new Square(11);
Console.WriteLine($"The area of the square is {square.Area()}\n"+
                  $"The perimeter of the square is {square.Perimeter()}\n"
    );


var rectangle = new Rectangle(5, 33);
Console.WriteLine($"The area for this given rectangle is {rectangle.Area()}\n" +
                  $"The perimeter for the rectangle is {rectangle.Perimeter()}");