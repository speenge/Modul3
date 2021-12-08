using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace M3Oblig1
{
    class Program
    {
        public static bool running = true;
        public static List<Person> Persons = new List<Person>();
        static void Main(string[] args)
        {
            HelpTxt.HelpText();

            //var db = new PersonDB();
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            sverreMagnus.Father = haakon;
            ingridAlexandra.Father = haakon;
            haakon.Father = harald;
            Persons.Add(sverreMagnus);
            Persons.Add(ingridAlexandra);
            Persons.Add(haakon);
            Persons.Add(harald);
            
            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon);
           
            //Console.WriteLine(Persons[0].GetDescription());
            //Console.WriteLine(Persons.Count);
            //Console.WriteLine(Persons[0].GetDescription());
            
            var input = new Input();
            
            var t = Persons.FirstOrDefault(item => item.Id == 17);
            //Console.WriteLine($"{t.LastName} {t.Mother}");
            while (running)
            {
                running = input.input();
            }
        }

    }
}
