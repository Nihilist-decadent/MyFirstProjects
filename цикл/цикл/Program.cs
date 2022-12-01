using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbers = 0; //нечетные
            uint evenNumbers = 0; //четные

            Console.WriteLine("введите первое число диапзона");
            int currentValue = int.Parse (Console.ReadLine());
            Console.WriteLine("введите второе");
            int limit = int.Parse (Console.ReadLine());

            while (currentValue <= limit)
            {
                if(currentValue%2 ==0)
                {
                    evenNumbers++;
                }
                else 
                {
                    oddNumbers++; 
                }
            }
            Console.WriteLine("количество нечетных чисел: " + oddNumbers);
            Console.WriteLine("количество четных чисел: " + evenNumbers);
            Console.ReadLine();
        }
    }
}
