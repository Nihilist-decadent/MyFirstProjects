using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace найти_уникальный
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 11, 11, 12, 33, 12 };
            int copy1 = myArray[0];
            for(int i=1; i<myArray.Length; i++)
            {
                if (copy1 == myArray[i])
                {
                    copy1=myArray[i];
                }
                else
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
