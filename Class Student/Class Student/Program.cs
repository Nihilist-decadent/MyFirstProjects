using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    internal class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstName = "Natasha";
            student.lastName = "Lapshowa";
            student.middleName = "Viacheslavowna";
            student.group = "Economist";
            student.age = 19;
            student.id = Guid.NewGuid();

            return student;
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();

            Console.WriteLine();
            Console.WriteLine();

            var secondStudent = new Student();
            secondStudent.firstName = "Noname";
            secondStudent.Print();
            Console.ReadKey();
        }
    }
}
