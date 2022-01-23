using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Pokemon
    {
        public string name { get; private set; }
        public string type { get; private set; }

        public Pokemon(string aName, string aType)
        {
            name = aName;
            type = aType;
        }
        public string GetName()
        {
            return name;
        }
        public string GetType()
        {
            return type;
        }
    }
}
