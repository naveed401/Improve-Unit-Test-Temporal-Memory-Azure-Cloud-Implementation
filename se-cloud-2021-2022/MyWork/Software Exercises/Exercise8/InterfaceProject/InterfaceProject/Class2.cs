
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Class2 : Interface1, Interface2 //Alt +Enter
    {
        public string Load(string fileName)
        {
            // your work
            throw new NotImplementedException();
        }

        public string namePos()
        {
            throw new NotImplementedException();
        }

        public bool Save(string saveString, string fileName)
        {
            // your work
            throw new NotImplementedException();
        }

        public void ThisHasTobeImplemented()
        {
            Console.WriteLine("Changing Implementation of Interface1");
        }

        public int ThrowMeANumber(int number)
        {
            Console.WriteLine("Changing Implementation of Interface1");
            return number + 1333;
        }
    }
}

