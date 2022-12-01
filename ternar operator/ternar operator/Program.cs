using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternar_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAlowed;

            string storedPassword = "qwe";
            string enteredPassword = Console.ReadLine();

            //if (storedPassword == enteredPassword)
            //{
            //    accessAlowed = true;
            //}
            //else
            //{
            //    accessAlowed = false;
            //}

            accessAlowed = storedPassword == enteredPassword ? true : false;

            Console.WriteLine(accessAlowed);
            Console.ReadLine();
        }
    }
}
