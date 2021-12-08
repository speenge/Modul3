using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorOppgFre
{
    class Address
    {
        private string StreetName;
        private int StreetNo;
        private int PostNo;
        private string PostPlace;

        public Address(string str1, int int1, int int2, string str2)
        {
            StreetName = str1;
            StreetNo = int1;
            PostNo = int2;
            PostPlace = str2;
        }
    }
}
