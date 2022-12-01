using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace развлечеи_с_циклами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int row = 0; row<=10;row++)
            {
                for (int column = 0; column <= 10; column++)
                {
                    if (row == 0 || row == 10 || column == 0 || column == 10)
                        Console.Write("@");
                    if (row == 1 || row == 9 || column == 1 || column == 9)
                        Console.Write("@");
                    if (row == 2 || row == 8 || column == 2 || column == 8)
                        Console.Write("@");
                    if (row == 3 || row == 7 || column == 3 || column == 7)
                        Console.Write("@");
                    else
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            Console.ReadKey();
        }
        
    }
}
