using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonOppg
{
    class Magicarp : IPokemon
    {
        public static int MaxHealth {get; set;}
        public static bool IsUseless = true;

        public Magicarp(int health)
        {
            MaxHealth = health;
        }

        public void LooseHealth(int dmg) => MaxHealth -= dmg;
        public void Splash()
        {
            Console.WriteLine($"No effect!");
        }
    }
}
