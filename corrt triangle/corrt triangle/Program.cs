using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corrt_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите высоту треугольника");
            int hight = int.Parse(Console.ReadLine());

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            for (int i = 0; i < hight; i++)
            {
                for (int j = hight; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            for (int i = 0; i < hight; i++)
            {
                for (int j =hight; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = hight; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
