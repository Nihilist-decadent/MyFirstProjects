using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace заполение_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол во жлементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int [elementsCount];
            for (int i = 0;i<myArray.Length;i++)
            {
                Console.Write($"Введитеэлемент массива подидексом{i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
