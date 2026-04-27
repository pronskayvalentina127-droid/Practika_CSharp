class FixedQueueProcessor<T>
{
    private MyFixedQueue<T> queue;
    public FixedQueueProcessor(int size)
    {
        queue = new MyFixedQueue<T>(size);
    }
    public void Add(T item)
    {
        queue.Enqueue(item);
    }
    public T Remove()
    {
        return queue.Dequeue();
    }
    public int GetCount()
    {
        return queue.Count;
    }
}

//класс-контролер