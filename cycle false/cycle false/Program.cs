using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_false
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            do
            {
                som++;
                Console.WriteLine("somethng");

            } while (som < 5);
            Console.ReadKey();
        }
    }
}
