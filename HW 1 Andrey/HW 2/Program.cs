using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "11 7";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
            }

            int[] ValueInt  = Array.ConvertAll(words, s => int.Parse(s));
            Console.WriteLine(String.Join(" ", ValueInt));
            Console.ReadKey();
        }
    }
}
