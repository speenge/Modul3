using System;

namespace RefactorOppgFre
{
    class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address("Tullekoppveien", 64, 3158, "Andebu");
            var person = new Person("Marie", 32, address1, "marie@getacademy.no");

            

            Console.WriteLine($"Hello, my name is {person.Name}!");
            Console.WriteLine($"I am {person.Age} years old, and i live in {person.}");
            Console.WriteLine($"my email address is: {email}");

            var name2 = "Terje";
            var age2 = "42";
            var address2 = new Address("Sjakkmesterveien", 69, 3238, "Larvik");

            var email2 = "Terje@getacademy.no";

            Console.WriteLine($"Hello, my name is {name2}!");
            Console.WriteLine($"I am {age2} years old, and i live in {address2}");
            Console.WriteLine($"my email address is: {email2}");
        }
    }
}
