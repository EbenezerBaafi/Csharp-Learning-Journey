using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    internal class Calculator<T>
    {
        public T Add(T x, T y) => (dynamic)x + y; // the dynamic type casting helps to bypass the data type check at compile time
        //public double Add(double x, double y) => x + y;
    }
}
