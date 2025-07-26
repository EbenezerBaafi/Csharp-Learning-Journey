using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal interface IAnimal
    {
         void Eat();
         void MakeSound(); 
    }

    public class Dog:IAnimal
    {
        public void Eat()
        {
            throw new MyException("Oops!! something went wrong");
        }
        public void MakeSound()
        {

        }
    }

}
