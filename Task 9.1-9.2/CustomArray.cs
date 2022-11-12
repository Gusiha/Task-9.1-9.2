using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._1_9._2
{
    public class CustomArray<T> : ICustomComparable<T>
    {
        public T[] array;
        //TODO Конструктор
        public CustomArray(int count)
        {
            array = new T[count];

        } 

        //TODO Индексатор
        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index < array.Length)
                {
                    array[index] = value;
                }
                else throw new Exception("Your index is more than array.Length");
            }
          
        }

        public int CustomCompare(T val)
        {
            string TextFormat = val.ToString();
            int sum = 0;
            foreach (var item in TextFormat)
            {
                sum+=CharUnicodeInfo.GetDigitValue(item);
            }
            return sum;           
        }


        //TODO Сортировка пузырьком используя метод сравнения из интерфейса


    }
}
