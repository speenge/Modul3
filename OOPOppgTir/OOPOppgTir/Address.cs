using System;
using System.ComponentModel.Design;

namespace OOPOppgTir
{
    class Addresses
    {
        public string StreetName;
        public string StreetNo;
        public string PostCode;
        public string City;
        public void ShowAddress()
        {
            Console.WriteLine($"Street name: {StreetName} StreetNo: {StreetNo} PostCode: {PostCode} City {City}.");
        }

        public Addresses(string AddrStreetName, string AddrStreetNo, string AddrPostCode, string AddrCity)
        {
            StreetName = AddrStreetName;
            StreetNo = AddrStreetNo;
            PostCode = AddrPostCode;
            City = AddrCity;
        }

    }
}
