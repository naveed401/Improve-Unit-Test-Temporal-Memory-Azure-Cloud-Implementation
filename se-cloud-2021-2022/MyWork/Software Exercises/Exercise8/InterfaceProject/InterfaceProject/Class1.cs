
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Class1 : Interface1 // Alt+Enter 
    {
        public int number;
        public void ThisHasTobeImplemented()
        {
            Console.WriteLine("The interface function ThisHasTobeImplemented has been implemented");
        }

        public int ThrowMeANumber(int number)
        {
            this.number = number;
            return number;
        }
    }
}



