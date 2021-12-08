using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonOppg
{
    interface IPokemon
    {
        public static int MaxHealth { get; set; }

        public abstract void LooseHealth(int dmg);

    }
}
