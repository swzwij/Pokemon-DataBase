using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDataBase
{
    class Inventory
    {
        private List<Pokemon> _pokemons;

        public Inventory()
        {
            _pokemons = new List<Pokemon>();
        }

        public void AadPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public Pokemon GetPokemons(int NumbPokemon)
        {
            return _pokemons[NumbPokemon];
        }
    }
}
