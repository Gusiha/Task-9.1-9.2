namespace Task_9._1_9._2
{
    public class CustomArray<T> : ICustomComparable<T> where T : ICustomComparable<T>
    {
        public CustomArray(int value)
        {
            _array = new T[value];
        }

        private T[] _array;

        public T this[int i]
        {
            get { return _array[i]; }
            set { _array[i] = value; }
        }

        public int CustomCompare(T value)
        {
            return value.CustomCompare(value);
        }

        public void Sort()
        {
            bool check = true;

            while (check)
            {
                check = false;

                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i].CustomCompare(_array[i]) < _array[i - 1].CustomCompare(_array[i - 1]))
                    {
                        var temp = _array[i];
                        _array[i] = _array[i - 1];
                        _array[i - 1] = temp;
                        check = true;
                    }
                }
            }
        }
    }


}

