using System;

namespace aaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            var something = new Textor("super text!");
            var SomeotherThing = new Textor("some other supertext");
            //Console.WriteLine(something.Name);
            //something.PrintName();
            something.PrintText();
            SomeotherThing.PrintName();
        }
    }
}
