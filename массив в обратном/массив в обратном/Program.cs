using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив_в_обратном
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55 };

            for(int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
        }
    }
}
