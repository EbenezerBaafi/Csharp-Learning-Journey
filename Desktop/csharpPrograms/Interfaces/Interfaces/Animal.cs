using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Animal
    {
        protected string name;

        public void MakeSound()
        {
            Console.WriteLine("The animal is making sounds...");
        }

        public abstract void Eat();
        /*{
            Console.WriteLine("The animal is making some funny sounds..");
        }*/

    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is eating....");
        }
    }
    public class Bird : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("You are about to feed the bird. What do you want to give it?");
            var food = Console.ReadLine();
            Console.WriteLine($"The bird is eating {food}.");
        }
    }

    public sealed class Chicken : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("The chicken is eating");
        }
    }



}
