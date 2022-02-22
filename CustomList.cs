using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    class CustomList<T> where T : IComparable<T>
    {
        public T[] _data;

        private int size = 1;
        private int lastIndex = 0;
        public CustomList()
        {
            _data = new T[size];
        }
        public CustomList(IEnumerable<T> array)
        {
            _data = (T[])array;
            lastIndex = array.Count();
        }
        public void Add(T value)
        {
            if (ArrayIsFull())
            {
                Resize(1);
            }
            _data[lastIndex] = value;
            lastIndex++;
        }
        public void AddRange(IEnumerable<T> rangeArray)
        {
            int newLenght = rangeArray.Count();
            for (int i = 0; i < newLenght; i++)
            {
                if (ArrayIsFull())
                    Resize(newLenght);
                _data[lastIndex] = rangeArray.ElementAt(i);
                lastIndex++;
            }
        }
        public void Remove(T value)
        {
            T[] newData = new T[_data.Length - 1];
            int j = 0;
            bool entry = false;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Equals(value) && !entry)
                {
                    entry = true;
                    continue;
                }
                newData[j++] = _data[i];
            }
            _data = newData;
        }
        public void RemoveAt(int index)
        {
            T[] newData = new T[_data.Length - 1];
            int j = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                newData[j++] = _data[i];
            }
            _data = newData;
        }
        public void Sort()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                for (int j = 0; j < _data.Length - 1; j++)
                {
                    if (_data[j].CompareTo(_data[j+1]) > 0)
                    {
                        T temp = _data[j];
                        _data[j] = _data[j + 1];
                        _data[j + 1] = temp;
                    }
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                yield return _data[i];
            }
        }
        private bool ArrayIsFull() => lastIndex == _data.Length || lastIndex == 0;

        private void Resize(int howMuchToAdd)
        {
           int newSize = _data.Length + howMuchToAdd;
           T[] newArray = new T[newSize];

           for (int i = 0; i < _data.Length; i++)
            {
                newArray[i] = _data[i];
            }
            _data = newArray;
        }
    }
}
