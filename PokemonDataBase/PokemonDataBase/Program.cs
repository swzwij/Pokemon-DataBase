using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Charmander = new Pokemon("Charmander");
            Pokemon Squirtle = new Pokemon("Squirtle");

            Inventory inventory = new Inventory();

            inventory.AadPokemon(Charmander);
            inventory.AadPokemon(Squirtle);

            Console.WriteLine(inventory.GetPokemons(0).Name);
            Console.WriteLine(inventory.GetPokemons(1).Name);
        }
    }
}
