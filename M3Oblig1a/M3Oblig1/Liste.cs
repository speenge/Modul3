using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Oblig1
{
    class Liste
    {
        public static void GetList()
        {
            var t = Program.Persons;
            foreach (var val in t)
            {
                Console.WriteLine(val.GetDescription());
            }
        }
    }
}
