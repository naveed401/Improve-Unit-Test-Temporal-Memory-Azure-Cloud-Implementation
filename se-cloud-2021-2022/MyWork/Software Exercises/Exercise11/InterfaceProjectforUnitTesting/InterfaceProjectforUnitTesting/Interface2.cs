
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjectforUnitTesting
{
    internal interface Interface2
    {
        public string namePos();

        public bool Save(string saveString, string fileName);
        public string Load(string fileName);
    }
}

