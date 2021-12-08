using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonOppg
{
    class Charizard : IPokemon
    {
        public static int MaxHealth { get; set; }

        public Charizard(int health)
        {
            MaxHealth = health;
        }

        public void LooseHealth(int dmg) => MaxHealth -= dmg;

        public static void EarthQuake(IPokemon target) => target.LooseHealth(40);
        public static void Flamethrower(IPokemon target) => target.LooseHealth(35);
        public static void Slash(IPokemon target) => target.LooseHealth(30);
        
    }
}
