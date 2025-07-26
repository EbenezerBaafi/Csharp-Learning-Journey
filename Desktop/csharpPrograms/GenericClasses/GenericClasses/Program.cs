// See https://aka.ms/new-console-template for more information
using GenericClasses;

Console.WriteLine("__________________________");
Console.WriteLine("______Generic Class_______");
Console.WriteLine("__________________________");


var mySample = new Sample<int>();
mySample.Field = 1;
Console.WriteLine(mySample.ShowInfo());

var charSample = new Sample<char>();
charSample.Field = 'a';
Console.WriteLine(charSample.ShowInfo());

Console.WriteLine("__________________________");
Console.WriteLine("________Calculator__________");
Console.WriteLine("__________________________");

var calc = new Calculator<int>();
Console.WriteLine($"Addition result is {calc.Add(12, 55)}");

var doubleCalc = new Calculator<double>();
Console.WriteLine($"Addition result is {doubleCalc.Add(12.43, 55.2)}");