using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_MethodOverriding
{
    public  class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound.");
        }
    }

    public  class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public  class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
