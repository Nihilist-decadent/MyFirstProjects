using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ключивое_слово_In
{
    internal class Program
    {
        static void Foo(params object[] parameters)
        {
            string message = "Тип данных{0}, значение {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Foo("Test", 5, 'q',5.86f, true);
        }
    }
}
