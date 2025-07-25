using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AdvanceCalculator : Calculator
    {
        /*int firstNumber;
        int secondNumber;*/

        public AdvanceCalculator (int firstNumber, int secondNumber)
            : base () // the base passes the number given to the calcutor pro to be solved
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        public double Power2()
        {
            return Math.Pow(firstNumber, 2);
        }

        public string DoAllOperations()
        {
            return
                /*$"Addition is: {Add()}\n" +
                $"Subtraction is: {Subtract()}\n" +*/
                base.DoAllOperations() +
                $"Power is: {Power2()}";
        }
    }
}
