using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static void Main()
        {
            Pokedex dex = new Pokedex();

            dex.AddPokemon(new Pokemon("Bulbasaur", "Grass"));
            dex.AddPokemon(new Pokemon("Charmander", "Fire"));
            dex.AddPokemon(new Pokemon("Squirtle", "Water"));
            dex.AddPokemon(new Pokemon("Chikorita", "Grass"));
            dex.AddPokemon(new Pokemon("Cyndaquil", "Fire"));
            dex.AddPokemon(new Pokemon("Totodile", "Water"));
            dex.AddPokemon(new Pokemon("Treecko", "Grass"));
            dex.AddPokemon(new Pokemon("Torchic", "Fire"));
            dex.AddPokemon(new Pokemon("Mudkip", "Water"));

            while (true)
            {
                string search;
                Console.WriteLine("\nSearch for Pokemon names or types");
                search = Console.ReadLine();
                Console.WriteLine("\n");

                foreach (Pokemon p in dex.GetPokemons())
                {
                    if (search == p.GetName())
                    {
                        Console.WriteLine("> " + p.GetName() + " " + p.GetType());
                    }
                    if (search == p.GetType())
                    {
                        Console.WriteLine("> " + p.GetName() + " " + p.GetType());
                    }
                }
            }
        }
    }
}
