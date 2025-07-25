// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------------------");
Console.WriteLine("------METHOD-----------");


Sum(9,13);
Sub(33, 32);
Sub(firstNumber: 30, secondNumber: 54); // this is the name argument (it is define the key:value pair)

var mulResult = Mul(10, 3);
Console.Write($"The mul method has returned: {mulResult}");
Console.WriteLine($"\nShow the result of the mul method directly {Mul(20, 33)}");
Console.WriteLine($"\nShow the result of the Div method directly {Div(20, 33)}");// for the division method (Expression bodied method)

void Sum(int a, int b)
{
    Console.WriteLine($"The sum of {a} and {b} is {a + b}");
}

void Sub (int firstNumber, int secondNumber)
{
    Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
}

int Mul(int firstNumber, int secondNumber)
{
    var result = firstNumber * secondNumber;
    //Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
    //return result;
    return firstNumber * secondNumber;
}

//Expressions bodied method
double Div(int firstNumber, int secondNumber) =>(double)firstNumber / secondNumber;