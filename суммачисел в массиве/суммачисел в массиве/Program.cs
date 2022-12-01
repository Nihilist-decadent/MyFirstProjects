using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace суммачисел_в_массиве
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.Write("Введите количество элементов маcива:\t");
            
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];
            
            for (int i = 0; i <myArray.Length; i++)
            {
                Console.Write($"\nВведитеэлемент массива под индексом {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 ==0)
                {
                    evenNumbersSum = evenNumbersSum + myArray[i];
                }
                else
                {
                    oddNumbersSum = oddNumbersSum + myArray[i];
                }
            }
            Console.WriteLine("cумма четных чиcел " + evenNumbersSum);
            Console.WriteLine("cумма нечетных чиcел " + oddNumbersSum);
            Console.ReadKey();
        }
    }
}
