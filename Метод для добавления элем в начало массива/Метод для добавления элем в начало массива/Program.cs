using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_для_добавления_элем_в_начало_массива
{
    internal class Program
    {
        static void Int(ref int[] array, int value, int index)          //метод для добавления по индексу//
        {
            int[] newArray = new int[array.Length + 1];      //присваиваем новому массиву длинну старого//
            newArray[index] = value;                       //писваеваем новому индексу значение//
            for (int i = 0; i < index; i++)                    //цикл для передачи элем до индекса из старого в новый массив//
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)         //цикл для передачи остальныхэлементов после нашего индекса//
                newArray[i + 1] = array[i];                  //обавляем новый элемент в старый массив//
            array = newArray;
        }
        static void Start(ref int[] array, int value)
        {
            Int(ref array, value, 0);
        }
        static void End(ref int[] array, int value)
        {
            Int(ref array, value, array.Length);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 4 };
            //Int(ref myArray, -1, 2);//
            //Start(ref myArray, -1);//
            //End(ref myArray, -1);//
        }
    }
}
