namespace MyStack
{
    public class MyStack<T>
    {
        private T[] elem;     
        private int length;      
        private int maxLength;   
        public MyStack(int maxLength)
        {
            if (maxLength <= 0) { throw new ArgumentException("Maximum length must be more than 0.");}
            length = 0;
            elem = new T[maxLength];
            this.maxLength = maxLength;
        }
        public void Push(T element)
        {
            if (length == maxLength) { throw new InvalidOperationException("Stack is full.");}
            elem[length] = element;
            length++;
        }
        public T Pop()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            T topElement = elem[length - 1];
            length--;
            return topElement;
        }
        public T Peek()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            return elem[length - 1];
        }

        public T[] Values()
        {
            T[] temp = new T[length];
            for (int i = 0; i < length; i++)
                temp[i] = elem[i];
            return temp;
        }
        public void Clear()
        {
            length = 0;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
    }
}
