namespace Task_9._1_9._2
{
    public class CustomArray<T> where T : ICustomComparable<T>
    {
        public T[] array;
        
        public CustomArray(int count)
        {
            array = new T[count];
        }

        
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
            return 2;
        }

        public void Sort()
        {
            int[] IntArr = new int[array.Length];
            int temp = 0;
            T Ttemp;
            
            // Преобразование элементов T в числа
            for (int i = 0; i < array.Length; i++)
            {
                IntArr[i] = CustomCompare(array[i]);
            }


            // Пузырьковая сортировка
            for (int write = 0; write < IntArr.Length; write++)
            {
                for (int sort = 0; sort < IntArr.Length - 1; sort++)
                {
                    if (IntArr[sort] > IntArr[sort + 1])
                    {
                        // Сортировка массива чисел
                        temp = IntArr[sort + 1];
                        IntArr[sort + 1] = IntArr[sort];
                        IntArr[sort] = temp;

                        // Параллельно с сортировкой массива чисел будет сортироваться массив объектов
                        Ttemp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = Ttemp;
                    }
                }
            }

        }


        //TODO Сортировка пузырьком используя метод сравнения из интерфейса


    }
}
