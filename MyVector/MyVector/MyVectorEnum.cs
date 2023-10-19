using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    internal class MyVectorEnum<T>:IEnumerator<T>
    {
        private T[] _data;
        private int _size;
        private int _currentIndex = -1;

        public MyVectorEnum(T[] data, int size)
        {
            _data = data;
            _size = size;
        }

        public bool MoveNext() 
        {
            _currentIndex++;
            return _currentIndex < _size;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public void Dispose()
        {
            
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                return _data[_currentIndex];
            }
        }
    }
}
