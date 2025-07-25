using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Calculator
    {
        protected int firstNumber; // with the protected access modifier child classes (classes that extends the parent class ie. Calculator) can get access to them but any other class can't get access.
        protected int secondNumber;

        public Calculator() { }
        public Calculator(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }

        public string DoAllOperations()
        {
            return
                $"Addition is: {Add()}\n" +
                $"Subtraction is: {Subtract()}";
        }   
    }
}
