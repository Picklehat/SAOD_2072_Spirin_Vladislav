using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyList<T>:IEnumerable<T>
    {
        ListNode<T>? First;
        ListNode<T>? Last;
        int listSize;

        public T this[int index]
        {
            get
            {
                return At(index);
            }
        }
        public MyList()
        {

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(First);
        }
        public void Append(T item)
        {
            ListNode<T> temp = new ListNode<T>(item);
            if(First == null && Last == null)
            {
                First = temp;
                Last = temp;
            }
            else 
            {
                temp.Prev = Last;
                Last.Next = temp;
                Last = temp;
            }
            listSize++;
        }

        public void Prepend(T item)
        {
            ListNode<T> temp = new ListNode<T>(item);
            if (First == null && Last == null)
            {
                First = temp;
                Last = temp;
            }
            else
            {
                temp.Next = First;
                First.Prev = temp;
                First = temp;
            }
            listSize++;
        }
        public T[] ToArray() 
        {
            if (First == null) { throw new InvalidOperationException("List is empty."); }
            T[] resultArray = new T[listSize];
            ListNode<T> currentNode = First;
            for (int i = 0; i < listSize; i++)
            {
                resultArray[i] = currentNode.value;
                currentNode.Next = currentNode;
            }
            return resultArray;
        }

        public int Find(T value)
        {
            if (First == null) { throw new InvalidOperationException("List is empty."); }
            ListNode<T> currentNode = First;
            for(int i = 0;i < listSize;i++)
            {
                if(currentNode.value.Equals(value))
                    return i;
                currentNode = currentNode.Next;
            }
            return -1;
        }

        public bool Contains(T value)
        {
            if (First == null) { throw new InvalidOperationException("List is empty."); }
            if (Find(value) != -1)
                return true;
            else
                return false;
        }

        public void SetValue(T value, int index)
        {
            if (index >= listSize || index < 0) { throw new InvalidOperationException("Index out of range."); }
            ListNode<T> temp = First;
            for (int i = 0; i < index; i++)
                temp = temp.Next;
            temp.value = value;
        }
        public T At(int index)
        {
            if (index >= listSize || index < 0) { throw new InvalidOperationException("Index out of range."); }
            ListNode<T> temp = First;
            for (int i = 0; i < index; i++)
                temp = temp.Next;
            return temp.value;
        }
        public void RemoveAt(int index)
        {
            if (index >= listSize || index < 0) { throw new InvalidOperationException("Index out of range."); }
            ListNode<T> currentNode = First;

            for (int i = 0; i < index; i++)
                currentNode = currentNode.Next;

            if (currentNode.Equals(Last))
            {
                if (Last.Equals(First))
                {
                    Last = First = null;
                }
                else
                {
                    Last = Last.Prev;
                    Last.Next = null;
                }
            }
            else if (currentNode.Equals(First))
            {
                if (Last.Equals(First))
                {
                    Last = First = null;
                }
                else
                {
                    First = First.Next;
                    First.Prev = null;
                }
            }
            else
            {
                currentNode.Prev.Next = currentNode.Next;
                currentNode.Next.Prev = currentNode.Prev;
            }
            listSize--;
        }

        public void Remove(T value)
        {
            int index = Find(value);
            RemoveAt(index);
        }
        
        public void Insert(int index, T value)
        {
            if (index >= listSize || index < 0) { throw new InvalidOperationException("Index out of range."); }
            ListNode<T> currentNode = First;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            ListNode<T> newNode = new ListNode<T>(value);
            if (listSize == 1)
            {
                First = newNode;
                First.Next = Last;
                Last.Prev = First;
            }
            else if (currentNode.Equals(First))
            {
                First.Prev = newNode;
                newNode.Next = First;
                First = newNode;
            }
            else if (currentNode.Equals(Last))
            {
                Last.Next = newNode;
                newNode.Prev = Last;
                Last = newNode;
            }
            else
            {
                newNode.Prev = currentNode.Prev;
                newNode.Next = currentNode;
                currentNode.Prev = newNode;
                newNode.Prev.Next = newNode;
            }
            listSize++;
        }

        private class ListNode<T>
        {
            public T value;
            public ListNode<T>? Next;
            public ListNode<T>? Prev;

            public ListNode(T item)
            {
                value = item;
            }
        }

        private class MyListEnumerator<T> : IEnumerator<T>
        {
            private ListNode<T>? _currentNode;
            private ListNode<T>? First;
            public MyListEnumerator(ListNode<T> First)
            {

                this.First = First;
            }

            public bool MoveNext() // решить
            {
                if (_currentNode == null)
                    _currentNode = First;
                else
                    _currentNode = _currentNode.Next;
                return _currentNode != null;
            }

            public void Reset()
            {
                _currentNode = null;
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
                    return _currentNode.value;
                }
            }

        }
    }
}
