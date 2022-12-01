using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH
{
    internal class Program
    {
        static void Line (string simbol, uint quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.Write(simbol);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите символ");
            string simbol = Console.ReadLine();
            Console.WriteLine("введите кол во их в строке");
            uint quantity = uint.Parse(Console.ReadLine());
            Line (simbol, quantity);
            Console.ReadKey();
         
        }
    }
}
