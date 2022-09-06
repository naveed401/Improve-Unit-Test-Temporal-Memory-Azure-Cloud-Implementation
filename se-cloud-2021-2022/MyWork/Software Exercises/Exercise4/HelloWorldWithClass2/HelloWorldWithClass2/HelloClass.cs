using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWithClass2
{
     class HelloClass
    {

       static void Main(String[] args)
        {
            Class1 obj = new Class1();
            obj.someline();
            Class2 obj1 = new Class2();
            Console.WriteLine("Area of Rectangle is " + obj1.Area());
        }
    }
}
