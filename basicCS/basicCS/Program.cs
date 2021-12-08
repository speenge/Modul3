using System;

namespace basicCS
{
    class Program
    {
        /*  To hovedting inne i en klasse:
         *      Felt - tilsvarer (nesten) Javascript globale variabler
         *      Metoder - tilsvarer funksjon i Javascript
         *      
         *  Pensum idag:
         *      C# er et sterkt typet programeringsspråk
         *      Intro til Visual Studio
         *      Grunnskjellettet i en class
         *      Variabler, tilordning, deklarasjon (ink. var) og datatyper
         *          bool - boolean (true/false)
         *          int - heltall
         *          float/double - desimaltall
         *          string - tekst
         *      Valgsetning
         *      Løkker - for og while som i Javascript - foreach (for tabeeler)
         *      Tabeller
         *      Metoder (funksjoner)
         *      Input og output
        */
        static void Main(string[] args)
        {
            // Deklarer en variabel av hver av de nevnte datatypene
            bool b;
            int i;
            float f;
            double d;
            string s;

            // Tilordning
            b = true;
            i = 5;
            f = 3.2f;
            d = 1.2;
            s = "string man";

            // Kan også deklarere og tilordne samtidig
            bool b2 = false;
            int i2 = 3;
            float f2 = 34.2534f;
            double d2 = 243.3222;
            string s2 = "sdasdas ss";
            
            var b3 = false;
            var i3 = 9;
            var f3 = 3.5f;
            var d3 = 43.555;
            var s3 = "heioo!";


            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Hallo! ingen parametere. ");
            //}
            //else
            //{
            //    Console.WriteLine("Hallo verden!");
            //}

            //for (var i = 0; i < args.Length; i++)
            //{
            //    var parameterNo = i + 1;
            //    Console.WriteLine("Parameter " + parameterNo + ": " + args[i]);
            //}
        }
    }
}
