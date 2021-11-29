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
            Pokemon shoe = new Pokemon("p");
            Pokemon apple = new Pokemon("Sweet Apple");

            Inventory inventory = new Inventory();

            inventory.AadPokemon(shoe);
            inventory.AadPokemon(apple);

            Console.WriteLine(inventory.GetPokemons(0).Name);
            Console.WriteLine(inventory.GetPokemons(1).Name);
        }
    }
}
