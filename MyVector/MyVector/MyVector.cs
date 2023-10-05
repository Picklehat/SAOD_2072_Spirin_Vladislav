using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    internal class MyVector<T>
    {
        private T[] _data;
        private int size;

        public int Size 
        { 
            get { return size; } 
        }
        public int Capacity
        {
            get { return _data.Length; }
        }

        public MyVector()
        {
            _data = new T[10];
        }

        public MyVector(int Capacity)
        {
            if (Capacity <= 0) { throw new ArgumentException("Maximum capacity must be more than 0."); }
            size = Capacity;
            _data = new T[size];
        }

        public void Add(T item)
        {
            if (size + 1 >= Capacity)
                Reserve(Capacity * 2);
            size++;
            SetValue(item, size-1);
        }

        public void SetValue(T item, int index) 
        {
            if (index >= size || index < 0) { throw new InvalidOperationException("Index out of range."); }
            _data[index] = item;
        }

        public void Resize(int newSize)
        {
            if (newSize > size)
            {
                if(newSize > Capacity)
                    Reserve(newSize);
                size = newSize;
            }
            else
            {
                size = newSize;
            }
        }

        public void Reserve(int newCapacity) //Если не изменяет память, на паре пришли к выводу, что резерв работает только в большую сторону.
        {
            if(newCapacity > Capacity)
            {
                T[] temp = new T[newCapacity];
                for (int i = 0; i < size; i++)
                    temp[i] = _data[i];
                _data = temp;
            }
        }

        public void ShrinkToFit()
        {
            T[] temp = new T[size];
            for (int i = 0; i < size; i++)
                temp[i] = _data[i];
            _data = temp;
        }

        public T this[int index]
        {
            get 
            {
                if (index >= size || index < 0) { throw new InvalidOperationException("Index out of range."); }
                return _data[index]; 
            }
            set
            {
                if (index >= size || index < 0) { throw new InvalidOperationException("Index out of range."); }
                _data[index] = value;
            }
        }


    }
}
