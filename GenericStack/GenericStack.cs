class MyStack<T>
{
    T[] values;
    public int Count { get; set; } = 0;
    public bool IsEmpty
    {
        get
        {
            if (Count == 0) return true;
            return false;
        }

        set { }
    }

    public MyStack(int capacity)
    {
        values = new T[capacity];
    }

    public void Push(T item)
    {
        values[Count++] = item;
    }

    public T Pop()
    {
        return values[--Count];
    }

    public T Peek()
    {
        return values[Count - 1];
    }
}