using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Oblig1
{
    class Show
    {
        
        public static void show(string val)
        {
            bool valid = false;
            var t = Program.Persons;
            foreach (char c in val)
            {
                valid = char.IsDigit(c);
            }

            if (valid)
            {
                var p = t.FirstOrDefault(item => item.Id == Convert.ToInt32(val));
                Console.WriteLine(p != null ? $"{p.GetDescription()}" : "denne personen eksisterer ikke enda prøv \"vis\"");
            }
            else Console.WriteLine("Please enter a digit");
        }
    }
}
