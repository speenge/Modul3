using System;
using System.Collections.Generic;

namespace PokemonOppg
{
    class Program
    {
        public static List<IPokemon> wildPokemon = new List<IPokemon>();
        public static Random r = new Random();
        static void Main(string[] args)
        {
            /*
             * Oppgave:

            Lag et interface som heter IPokemon som har en property Health og en metode LooseHealth()
            
            Lag en klasse Magicarp som har en property IsUseless og en metode som heter Splash.
            
            Lag en annen Klasse med din favoritt pokemon, og metoder som heter det samme som attacktypene til pokemonen du har valgt.
            I attackmetodene skal du ta inn en IPokemon som parameter og kalle den sin LooseHealth metode. 
            
            Magicarp og din favorittpokemon klasse skal begge arve fra IPokemon og begge må ha sin egen constructor som setter health. 
            
            
            Lag noen flere flere forskjellige Pokemon, og legg alle i en liste List<IPokemon> wildPokemon i program.cs
            
            Lag en metode som returnerer en IPokemon som heter GetWildPokemon() som velger og returnerer en random pokemon fra wildPokemon listen.
            
            Definer en while-løkke som henter ut en wildpokemon og lar den sloss mot magicarp helt frem til magicarp har 0 i health
            */

            wildPokemon.Add(new Blastoise(200));
            wildPokemon.Add(new Kyogre(255));
            wildPokemon.Add(new Charizard(200));
            Magicarp magicarp = new Magicarp(100);
            bool fight = true;
            
            IPokemon YourPokemon = GetWildPokemon();
            while (fight)
            {
                if (YourPokemon == wildPokemon[0])
                {
                    int RandNum = r.Next(0, 3);
                    switch (RandNum)
                    {
                        case 0:
                            Console.WriteLine("Blastoise used surf and did 40 damage!");
                            Blastoise.Surf(magicarp);
                            break;
                        case 1:
                            Console.WriteLine("Blastoise used Blizzard and did 35 damage!");
                            Blastoise.Blizzard(magicarp);
                            break;
                        case 2:
                            Console.WriteLine("Blastoise used earthquake and did 40 damage!");
                            Blastoise.EarthQuake(magicarp);
                            break;
                        default:
                            Console.WriteLine("oops");
                            break;
                    }
                } 
                else if (YourPokemon == wildPokemon[1])
                {
                    int RandNum = r.Next(0, 3);
                    switch (RandNum)
                    {
                        case 0:
                            Console.WriteLine("Kyogre used Waterspout and did 50 damage!");
                            Kyogre.WaterSpout(magicarp);
                            break;
                        case 1:
                            Console.WriteLine("Kyogre used Thunder and did 40 damage!");
                            Kyogre.Thunder(magicarp);
                            break;
                        case 2:
                            Console.WriteLine("Kyogre used Icebeam and did 45 damage!");
                            Kyogre.IceBeam(magicarp);
                            break;
                        default:
                            Console.WriteLine("Kyogre oppsie.");
                            break;
                    }
                }
                else if (YourPokemon == wildPokemon[2])
                {
                    int RandNum = r.Next(0, 3);
                    switch (RandNum)
                    {
                        case 0:
                            Console.WriteLine("Charizard used Earthquake and did 40 damage!");
                            Charizard.EarthQuake(magicarp);
                            break;
                        case 1:
                            Console.WriteLine("Charizard used Flamethrower and did 35 damage!");
                            Charizard.Flamethrower(magicarp);
                            break;
                        case 2:
                            Charizard.Slash(magicarp);
                            Console.WriteLine("Charizard used Slash and did 30 damage!");
                            break;
                        default:
                            Console.WriteLine("Charizard oppsie.");
                            break;
                    }
                }
                if (Magicarp.MaxHealth <= 0) fight = false;
                Console.WriteLine(Magicarp.MaxHealth <= 0 ? "Magicarp fainted": $"Magicarp has {Magicarp.MaxHealth} health");
                Console.WriteLine();
            }
        }

        public static IPokemon GetWildPokemon()
        {
            int a = r.Next(0, wildPokemon.Count);
            return wildPokemon[a];
        }
    }
}
