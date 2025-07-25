using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();

    }
    public  class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side;
        }
        public override double Perimeter()
        {
            return side * 4;
        }
    }

    public class Rectangle : Shape
    {
        double length;
        double breadth;

        public  Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double Area()
        {
            return length * breadth;
        }

        public override double Perimeter()
        {
            return 2*(length + breadth);
        }
    }

}
