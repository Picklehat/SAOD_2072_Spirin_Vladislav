using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class MyQueue<T>
    {
        private T[] _data;
        private int currentIn;
        private int currentOut;
        private int count;

        public int Capacity
        {
            get
            {
                return _data.Length;
            }
        }

        public int Count 
        {
            get 
            {
                return count;
            } 
        }

        public MyQueue(int Capacity)
        {
            if (Capacity <= 0) { throw new ArgumentException("Maximum capacity must be more than 0."); }
            _data = new T[Capacity];
        }
        public void Enqueue(T value)
        {
            if(count == _data.Length) { throw new InvalidOperationException("Queue is full."); }
            _data[currentIn++] = value;
            count++;
            if(currentIn >= _data.Length)
                currentIn = 0;
        }
        public T Dequeue()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Queue is empty."); }
            T tepm = _data[currentOut++];
            count--;
            if (currentOut >= _data.Length)
                currentOut = 0;
            return tepm;
        }
        public T Peek()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Queue is empty."); }
            return _data[currentOut];
        }

        public T[] ToArray()
        {
            T[] temp = new T[count];
            for(int i = 0, j = currentOut; i < count; i++, j++)
            {
                if (j >= _data.Length)
                    j = 0;
                temp[i] = _data[j];
            }
            return temp;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }

    }
}
