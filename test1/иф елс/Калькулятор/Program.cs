using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;

            Console.WriteLine("ввкдите первое число");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ввкдите второе число");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("введите значение");
            string something=Console.ReadLine();

            if (something == +)
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
