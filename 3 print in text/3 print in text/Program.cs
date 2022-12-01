using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_print_in_text
{
    internal class Program
    {
        class Student
        {
            public Student1(string lastName, DateTime birthday)
            {
                this.lastName = lastName;
                this.birthday = birthday;

            }
            public Student2(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
            {
                this.firstName = firstName;
                this.middleName = middleName;
            }
            public Student3(string lastName, string firstName, string middleName, DateTime birthday)
            {
                this.firstName = firstName;
                this.middleName = middleName;
            }
            public Student4(string lastName, string firstName, string middleName, DateTime birthday)
            {
                this.firstName = firstName;
                this.middleName = middleName;
            }
            public void SetLastName(string LastName)
            {
                this.lastName = LastName;
            }

            private string firstName;
            private string middleName;
            private string lastName;
            private DateTime birthday;
            public void Print()
            {
                Console.WriteLine($"Name: {firstName}\nLast name: {lastName}\nMiddle name: {middleName}\nBirthday {birthday}");
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Jothef", "Jonatanowich", "Jostar", new DateTime(1910, 1, 5));
            Student student2 = new Student("Jothef", "Jonatanowich", "Jostar", new DateTime(1910, 1, 5));

            Student student3 = new Student("Jothef", "Jonatanowich", "Jostar", new DateTime(1910, 1, 5));
            Student student4 = new Student("Jothef", "Jonatanowich", "Jostar", new DateTime(1910, 1, 5));
            student1.Print();
        }
    }
}
