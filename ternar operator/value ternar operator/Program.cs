using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_ternar_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 0 : inputData;

            Console.WriteLine(outputData);
        }
    }
}
