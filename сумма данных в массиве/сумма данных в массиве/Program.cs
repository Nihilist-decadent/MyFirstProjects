using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_данных_в_массиве
{
    internal class Program
    {
        static int Sum(int a)
        {
            if (a < 10)
            return a;
            int digit = a % 10;
            return digit+Sum(a / 10);
        }
        static void Main(string[] args)
        {
            int ab = 561;
            int result = Sum(ab);
            Console.WriteLine(result);
            //int s = 0;
            //while (a > 0)
            //{

            //    s = s + a % 10;
            //    a = a / 10;

            //}
            //Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
