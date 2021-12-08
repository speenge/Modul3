using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonOppg
{
    class Kyogre : IPokemon
    {
        public int MaxHealth { get; set; }

        public Kyogre(int health) => MaxHealth = health;

        public void LooseHealth(int dmg) => MaxHealth -= dmg;

        public static void WaterSpout(IPokemon target) => target.LooseHealth(50);
        public static void Thunder(IPokemon target) => target.LooseHealth(40);
        public static void IceBeam(IPokemon target) => target.LooseHealth(45);
    }
}
