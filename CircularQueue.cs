public class MyCircularQueue
{
    private readonly int[] _data;
    private int _head;
    private int _tail;
    private int _size;
    private readonly int _capacity;

    public MyCircularQueue(int k)
    {
        _data = new int[k];
        _capacity = k;
        _head = 0;
        _tail = 0;
        _size = 0;
    }

    public bool EnQueue(int value)
    {
        if (IsFull()) return false;

        _data[_tail] = value;
        _tail = (_tail + 1) % _capacity;
        _size++;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty()) return false;

        _head = (_head + 1) % _capacity;
        _size--;
        return true;
    }

    public int Front()
    {
        return IsEmpty() ? -1 : _data[_head];
    }

    public int Rear()
    {
        if (IsEmpty()) return -1;
        int rearIndex = (_tail - 1 + _capacity) % _capacity;
        return _data[rearIndex];
    }

    public bool IsEmpty() => _size == 0;

    public bool IsFull() => _size == _capacity;
}
