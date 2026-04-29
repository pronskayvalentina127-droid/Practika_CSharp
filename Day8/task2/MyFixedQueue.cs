class MyFixedQueue<T> // <T> — обобщение (работает с любым типом)
{
    private T[] items; // массив для хранения элементов
    private int head; //индекс самого старого элемента
    private int count; //кол-во элементов сейчас
    public MyFixedQueue(int size)
    {
        items = new T[size]; //массив фиксированого размера
    }
    public void Enqueue(T item) //Enqueue — добавление (с автоматическим удалением старого)
    {
        int index = (head + count) % items.Length;
        items[index] = item;
        if (count < items.Length)
            count++;
        else
            head = (head + 1) % items.Length;
    }
    public T Dequeue() //Dequeue — извлечение первого элемента
    {
        T result = items[head];
        head = (head + 1) % items.Length;
        count--;
        return result;
    }
    public int Count { get { return count; } }
}

//дженерик/коллекция
