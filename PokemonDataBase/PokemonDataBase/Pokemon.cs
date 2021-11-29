using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDataBase
{
    class Pokemon
    {
        public string Name { get; private set; }

        public Pokemon(string name)
        {
            Name = name;
        }
    }
}
