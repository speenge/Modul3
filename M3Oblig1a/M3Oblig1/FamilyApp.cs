using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Oblig1
{
    class FamilyApp
    {

        public FamilyApp(params Person[] people)
        {
            var str = "";
            List<Person> ChildrenList = new();

            foreach (var person in people)
            {
                if (person.Father != null) ChildrenList = Program.Persons.FindAll(item => item.Father != null && item.Father.Id == person.Id);
                if (person.Mother != null) ChildrenList = Program.Persons.FindAll(item => item.Mother!= null && item.Father.Id == person.Id);
                if (ChildrenList.Count != 0)Console.WriteLine($"{person.FirstName}\nBarn:");
                if (ChildrenList.Count != 0) foreach (var a in ChildrenList) Console.WriteLine($"\t{a.FirstName} Id=({a.Id})");
                ChildrenList.Clear();
            }

            //foreach (var AAA in ass)
            //{
            //    Console.WriteLine(AAA.FirstName + "\n");
            //}
        }
    }
}
