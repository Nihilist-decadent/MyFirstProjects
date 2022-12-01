using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawy_z_null
{
    internal class Program
    {
        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "333019467" } };
            return person;
        }
        static void Main(string[] args)
        {
           Person person = GetPerson();
            Console.WriteLine(person?.Contacts?.PhoneNumber ?? "net dannyh");
            Console.ReadKey();
        }

    }
}
