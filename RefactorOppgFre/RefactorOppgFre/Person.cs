using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorOppgFre
{
    class Person
    {
        private string Name;
        private string Email;
        private int Age;
        private Address Address;

        public Person(string name, int age, Address adress, string email)
        {
            Name = name;
            Age = age;
            Email = email;
            Address = adress;
        }
    }
}
