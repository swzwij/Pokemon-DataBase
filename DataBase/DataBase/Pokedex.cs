using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Pokedex
    {
        private List<Pokemon> pokemons;

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon aPokemon)
        {
            pokemons.Add(aPokemon);
        }
        public List<Pokemon> GetPokemons()
        {
            return pokemons;
        }
    }
}
