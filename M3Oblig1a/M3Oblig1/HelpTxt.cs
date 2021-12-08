using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Oblig1
{
    class HelpTxt
    {
        public static void HelpText()
        {
            Console.Clear();
            Console.WriteLine(@"
hjelp - Viser denne teksten.
liste - Lister alle personer med id, fornavn, føsdelsår, dødsår og navn og id på mor å far om det finnes registrert.
vis <id> - Viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)
exit - Avslutter");
        }
    }
}
