using System;

public class CircularBuffer<T>
{
    private int start;
    private int count;
    private int capacity;
    private T[] items;

    public CircularBuffer(int capacity)
    {
        this.items = new T[capacity];
        this.capacity = capacity;
        this.start = 0;
        this.count = 0;
    }

    public T Read()
    {
        if (count == 0)
            throw new InvalidOperationException();

        var i = start % capacity;
        var item = items[i];
        start++;
        count--;
        return item;
    }

    public void Write(T value)
    {
        if (count >= capacity)
            throw new InvalidOperationException();

        var i = (start + count) % capacity;
        items[i] = value;
        count++;
    }

    public void Overwrite(T value)
    {
        if (count < capacity)
        {
            this.Write(value);
        }
        else
        {
            var i = start % capacity;
            items[i] = value;
            start++;
        }
    }

    public void Clear()
    {
        if (count != 0)
        {
            this.start = 0;
            this.count = 0;
        }
    }
}