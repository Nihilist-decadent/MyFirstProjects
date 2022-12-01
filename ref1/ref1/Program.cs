using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref1
{
    /*
     * Написат метод ресайз с использованием РЕФ
     * Метод должен увеличевать и уменьшать колво элементов
     */

    internal class Program
    {
        static void MyResize<T>(ref T[] Array, int elements) //копируем старый массив и создаем кол во элементов//
        {
            T[] NewArray = new T[elements]; //создаем новый массив//

            for(int i = 0; i<Array.Length && i<NewArray.Length; i++)            //*добавлем условие (&& i<NewArray.Length) для того чтобы можно было уменьшить
                                                                            // колво элементов массива
            {                                                                   
                NewArray[i] = Array[i]; //присваиваем зачения из старого массива в новый// 
            }
            Array = NewArray; //заменяем ссылку старого массива на новый//
        }
    
        static void Main(string[] args)
        {
            //int[] myArray = { 3, 1, 5 };

            Console.WriteLine("u wanna new length of massive? int how many");
            int elements = int.Parse(Console.ReadLine());

            //MyResize(ref myArray, (elements));

            string[] strArray = { "test", "some", "were" };
            MyResize(ref strArray, (elements));

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.ReadKey();

            for (int i = 0; i < strArray.Length; i++)                                   //закоментировал числовые типы данных, для проверки работы со string
            {
                Console.WriteLine(strArray[i]);
            }
            Console.ReadKey();

        }
    }
}
