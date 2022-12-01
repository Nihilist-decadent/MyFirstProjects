using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace свитч
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first, second;
            string action;

            Console.WriteLine("введите число 1");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число 2");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("введите знак + - * /");
            action = Console.ReadLine();
            
            switch (action)
            {
                case "+":
                    Console.WriteLine(first + second);
                    break;
                case "-":
                    Console.WriteLine(first - second);
                    Console.ReadKey();
                    break;
                case "/":
                    Console.WriteLine(first / second);
                    Console.ReadKey();
                    break;
                case "*":
                    Console.WriteLine(first * second);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
                    

            }
        }
    }
}
