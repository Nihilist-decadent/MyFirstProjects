using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("inf about student:");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Middle name: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }
        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}
