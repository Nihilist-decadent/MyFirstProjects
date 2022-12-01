using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace подщет_чисел_циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;   //нечетное
            uint evenNumberCount = 0;  //четное

            Console.WriteLine("введите первое число диапозона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("введите последнее число диапозона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumberCount++;
                }
                else
                {
                    oddNumberCount++;
                }
                currentValue++;
            }

            Console.WriteLine("кол во нечетных чисел" + oddNumberCount);
            Console.WriteLine("кол во четных чисел" + evenNumberCount);
            Console.ReadLine();
        }
    }
}
