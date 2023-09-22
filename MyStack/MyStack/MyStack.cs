namespace MyStack
{
    public class MyStack<T>
    {
        private T[] data;     
        private int currentIndex;      
        public int Capacity
        {
            get { return data.Length; }
        }
        public int Count
        {
            get { return currentIndex; }
        }
        public MyStack(int Capacity)
        {
            if (Capacity <= 0) { throw new ArgumentException("Maximum currentIndex must be more than 0.");}
            currentIndex = 0;
            data = new T[Capacity];
        }
        public void Push(T item)
        {
            if (currentIndex == Capacity) { throw new InvalidOperationException("Stack is full.");}
            data[currentIndex] = item;
            currentIndex++;
        }
        public T Pop()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            currentIndex--;
            return data[currentIndex]; ;
        }
        public T Peek()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            return data[currentIndex - 1];
        }

        public T[] Values()
        {
            T[] temp = new T[currentIndex];
            for (int i = 0; i < currentIndex; i++)
                temp[i] = data[i];
            return temp;
        }
        public void Clear()
        {
            currentIndex = 0;
        }
        public bool IsEmpty()
        {
            return currentIndex == 0;
        }
    }
}
