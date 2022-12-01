using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch1Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //не працует из за названия проекта :( *
            string a = Console.ReadLine();
            switch (a)
            {
                case "+":
                    Console.WriteLine("+");
                    break;
                case "-":
                    Console.WriteLine("-");
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
                    Console.ReadKey();
            }
           
        }
    }
}
