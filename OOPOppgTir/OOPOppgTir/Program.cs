using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace OOPOppgTir
{
    class Program
    {
        static void Main(string[] args)
        {
            var per = new Person()
            {
                FirstName = "Per",
                LastName = "Olsen",
                Address = new Addresses("Veien", "17", "1234", "Byen"),
                Employer = new Employers()
                {
                    Name = "Bedriften AS",
                    Address = new Addresses("Gata", "71", "4321", "Byen")
                }
            };
            Console.WriteLine(@$"Firstname: {per.FirstName} Lastname: {per.LastName} Address: 
    Street name: {per.Address.StreetName}");
        }
    }
}
