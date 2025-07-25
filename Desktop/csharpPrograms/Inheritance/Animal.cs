using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The cat is eating meat.");
        }
        public void Meaw()
        {
            Console.WriteLine("The cat is singing meaw meaw meaw");
        }
    }

    public class Bird : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The bird is eating seeds.");
        }
        public void LayEggs()
        {
            Console.WriteLine("The bird is laying eggs.");
        }
    }

    public class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("The penguin is swimming");
        }
    }
}
