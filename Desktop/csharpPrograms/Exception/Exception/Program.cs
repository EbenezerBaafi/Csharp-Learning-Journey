// See https://aka.ms/new-console-template for more information
using Debugging;

Console.WriteLine("______________________________");
Console.WriteLine("______Exception___________");

//try
//{
//    Console.Write("Enter a number: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"You entered the number {number}.");
//}
//catch (Exception ex)
//{

//    Console.WriteLine("The input is not an integer.");
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("The execution of the program finished.");
//}


//try
//{
//	var dog = new Dog();
//	dog.Eat();
//}
//catch (MyException e)
//{

//    Console.WriteLine(e.Message); ;
//}

var bankAccount = new BankAccount(100);
Console.WriteLine($"Your bank account balance is: {bankAccount.Balance}\n");
bankAccount.Deposit(300.4);
Console.WriteLine($"Your balance is {bankAccount.Balance}\n");
bankAccount.Withdraw(600);
Console.WriteLine($"Your balance is {bankAccount.Balance}");