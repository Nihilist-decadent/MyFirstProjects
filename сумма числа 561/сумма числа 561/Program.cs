using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_числа_561
{
    internal class Program
    {
        static int Sum(int value)
        {
            if (value < 10)
                return value;
            int digit = value % 10;
            int nextValue = value / 10;
            return digit + Sum(nextValue);
        }
        static void Main(string[] args)
        {
            int ab = 561;
            int result = Sum(ab);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
