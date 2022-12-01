using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ключевое_слово_out
{
    internal class Program
    {
        static void Oute(out int value)
        {
            value = 5;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);
            Console.ReadKey();       
        }
    }
}
