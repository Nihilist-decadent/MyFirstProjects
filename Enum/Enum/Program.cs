using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\tEnum{key}\tKeyCode{keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("вы нажали 2Enter");
                }
            }
            Console.ReadKey();
        }
    }
}
