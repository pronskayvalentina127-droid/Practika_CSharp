class MyFixedQueue<T>
{
    private T[] items;
    private int head;
    private int count;
    public MyFixedQueue(int size)
    {
        items = new T[size];
    }
    public void Enqueue(T item)
    {
        int index = (head + count) % items.Length;
        items[index] = item;
        if (count < items.Length)
            count++;
        else
            head = (head + 1) % items.Length;
    }
    public T Dequeue()
    {
        T result = items[head];
        head = (head + 1) % items.Length;
        count--;
        return result;
    }
    public int Count { get { return count; } }
}

//дженерик/коллекция