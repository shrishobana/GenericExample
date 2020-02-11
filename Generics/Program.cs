using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyClass<T>
    {
        public bool compare(T a,T b)
        {
            if(a.Equals(b))
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> my = new MyClass<string>();
            bool result = my.compare("Hi","Hi");
            Console.Write(result);
           
            MyClass<int> my1= new MyClass<int>();
            bool result1 = my1.compare(10, 5);
            Console.Write(result1);
            Console.ReadKey();

        }
    }
}
