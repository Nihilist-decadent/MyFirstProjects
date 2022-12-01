using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Удаление_элементов_массива
{
    internal class Program
    {
        static void Int(ref int[] array, int index)         
        {
            int[] newArray = new int[array.Length - 1];     
            for (int i = 0; i < index; i++)                   
                newArray[i] = array[i];
            for (int i = index+1; i < array.Length; i++)       
                newArray[i - 1] = array[i];                  
            array = newArray;
        }
        static void Start(ref int[] array)
        {
            Int(ref array, 0);
        }
        static void End(ref int[] array)
        {
            Int(ref array, array.Length);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 4, 6 };
            //Int(ref myArray, 2);//
            //Start(ref myArray);//
            End(ref myArray);//
        }
    }
}
