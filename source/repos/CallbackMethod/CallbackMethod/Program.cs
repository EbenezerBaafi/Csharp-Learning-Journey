using System.Diagnostics.CodeAnalysis;

Console.WriteLine("---------------------");
Console.WriteLine("---Callback Method---");


Sum(5, 9, ShowResult);

Console.WriteLine("---------------------");
Console.WriteLine("---Anonymous Methods---");

Subtract(50, 20, (result) =>
{
    Console.WriteLine($"Result for subtract is: {result}");
});//Lambda expression

Sum(60, 10, (result, message) =>
{
    Console.WriteLine($"Result for sum is: {result}");

});




var show = delegate (int result)
{
    Console.WriteLine($"Result using delegate calling: {result}");
};

Subtract(10, 20, show);

show(50);

# region Methods

void ShowResult(int result, string message)
{
    Console.WriteLine($"Result is => {result}");
}

void Sum(int x, int y, Action<int, string> showResult)
{
    var result = x + y;
    showResult(result,"");
}
void Subtract(int x, int y, Action<int> showResult)
{
    var result = x - y;
    ShowResult(result, "");
}

#endregion Methods


Console.WriteLine("---------------------");
Console.WriteLine("---Delegates---");

// Anonymous methods using a delegate method
// Delegate is an object that refers to a method.
// this method can be called after an event. eg. click on a button, enter a text.
// Using delegate you can encapsulate the methods
// can also be used for callback methods.
// can add one or more methods for a single event.
// modifier delegat returntype DelegateName(parameters);
// Delegate doesn't have a code block

void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} =  {x * y}");
}

var NewSum = new Calculate(Add);
NewSum(12, 14);

var calc = new Calculate(Multiply);
calc(50, 12);

public delegate void Calculate(int x, int y); // any method that has the same fields as delegate can be defined by this method
