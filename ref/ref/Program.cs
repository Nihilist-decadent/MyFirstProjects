using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ref
{
    class Program
    {
        static void ResizeUp(ref int[] arr, ref int qtyElements)
        {
            qtyElements++;
            int[] myArray = new int[qtyElements];
            for (int i = 0; i < qtyElements - 2; i++) myArray[i] = arr[i];
            arr = myArray;
        }

        static void ResizeDown(ref int[] arr, ref int qtyElements)
        {
            qtyElements--;
            int[] myArray = new int[qtyElements];
            for (int i = 0; i < qtyElements; i++) myArray[i] = arr[i];
            arr = myArray;
        }

        static void Main (string[] args)
        {
            Console.WriteLine("int number of elements");

            int qtyElements = int.Parse(Console.ReadLine());

            int[] myArray = new int[qtyElements];

            Console.WriteLine("wat u gonna do? -/+ ?");

            string Answer =(Console.ReadLine());
            
            if(Answer == "+")
            {
                ResizeUp(ref myArray, ref qtyElements);
            }
            else if(Answer == "-")
            {
                ResizeDown(ref myArray, ref qtyElements);
            }
            else
            {
                Console.WriteLine("Попробуйте ещё раз!");

                return;
            }
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();

        }

    }
}
