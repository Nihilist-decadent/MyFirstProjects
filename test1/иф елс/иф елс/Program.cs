using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace иф_елс
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число 1");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число 2");
            double b = int.Parse(Console.ReadLine());

            {
                int x;

                x = int.Parse(Console.ReadLine());

                if (x)
                {
                    Console.WriteLine("ваше число четное");
                }
                else
                {
                    Console.WriteLine("ваше число нечетное");
                }
                Console.ReadKey();
            }
        }
    }
}
