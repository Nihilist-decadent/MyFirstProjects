using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наименьший_эемент_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 8, 2, 3, 4, 10, 6};

            int min = MyArray[0];

            for (int i =1; i < MyArray.Length; i++)
            {
                if (MyArray[i]<min)
                {
                    min=MyArray[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
