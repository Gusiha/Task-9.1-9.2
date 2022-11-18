using System.Collections;

namespace Task_9._1_9._2
{
    public class CustomArray<T> : ICustomComparable<T>, IEnumerable<T> where T : ICustomComparable<T>
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
                        (_array[i - 1], _array[i]) = (_array[i], _array[i - 1]);
                        check = true;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomArrayEnumerator<T>(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        class CustomArrayEnumerator<U> : IEnumerator<U>
        {
            U[] _array;

            int position = -1;

            public CustomArrayEnumerator(U[] _array)
            {
                this._array = _array;
            }

            public object Current => throw new NotImplementedException();

            U IEnumerator<U>.Current
            {
                get
                {
                    if (position == -1 || position >= _array.Length)
                        throw new ArgumentException();
                    return _array[position];
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (position < _array.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }


}

