using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    internal class Sample<T>
    {
        T field;
        public T Field 
        { 
            get {  return field; }
            set {  field = value; }
        }
        public string ShowInfo()
        {
            return ($"The value for field is {field} and it is of type {field.GetType()}");
        }
    }
}
