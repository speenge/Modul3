using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonOppg
{
    class Blastoise : IPokemon
    {
        public int MaxHealth { get; set; }

        public Blastoise(int health) => MaxHealth = health;

        public void LooseHealth(int dmg) => MaxHealth -= dmg;

        public static void Surf(IPokemon target) => target.LooseHealth(40);
        public static void Blizzard(IPokemon target) => target.LooseHealth(35);
        public static void EarthQuake(IPokemon target) => target.LooseHealth(40);

    }
}
