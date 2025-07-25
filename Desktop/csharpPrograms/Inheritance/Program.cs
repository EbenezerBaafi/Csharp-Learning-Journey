using Inheritance;

Console.WriteLine("----------------------------------");
Console.WriteLine("---------Inheritance--------------");

Console.WriteLine("\n---------Result for calculator class (Parent class)--------------");
var calc = new Calculator(5, 19);
/*Console.WriteLine($"Additon result is:{calc.Add()} ");
Console.WriteLine($"Subtraction  result is:{calc.Subtract()} ");*/
Console.WriteLine(calc.DoAllOperations());


Console.WriteLine("\n---------Result for AdvanceCalculator class (child class)--------------");
var AdvanceCalc = new AdvanceCalculator(22, 11);
/*Console.WriteLine($"The power result is: {pow.Power2()}");
Console.WriteLine($"The Addition result is: {pow.Add()}");
*/
Console.WriteLine(AdvanceCalc.DoAllOperations());

Console.WriteLine("\n-------------Animal Class------------------");
/*var penguin = new Penguin();
penguin.Eat();
penguin.LayEggs();
penguin.Swim();*/

var cat = new Cat();
cat.Eat();

var bird = new Bird();
bird.Eat();

Console.WriteLine("\n----------------------------------");
Console.WriteLine("---------Bank Account Classs--------------");

var bankAccount = new BankAccount(150.0F);
Console.WriteLine($"Your current balance is GH₵{bankAccount.balance}");
bankAccount.Deposit(100);
Console.WriteLine($"Your new balance is GH₵{bankAccount.balance}");
bankAccount.Withdraw(47);
Console.WriteLine($"Your balance after the withdrawal is  GH₵{bankAccount.balance}");
bankAccount.Withdraw(500);
Console.WriteLine($"Your balance after the withdrawal is  GH₵{bankAccount.balance}");
