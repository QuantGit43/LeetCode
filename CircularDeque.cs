public class MyCircularDeque
{
    private readonly int[] _data;
    private int _head;
    private int _tail;
    private int _size;
    private readonly int _capacity;

    public MyCircularDeque(int k)
    {
        _data = new int[k];
        _capacity = k;
        _head = 0;
        _tail = 0;
        _size = 0;
    }

    public bool InsertFront(int value)
    {
        if (IsFull()) return false;

        _head = (_head - 1 + _capacity) % _capacity;
        _data[_head] = value;
        _size++;
        return true;
    }

    public bool InsertLast(int value)
    {
        if (IsFull()) return false;

        _data[_tail] = value;
        _tail = (_tail + 1) % _capacity;
        _size++;
        return true;
    }

    public bool DeleteFront()
    {
        if (IsEmpty()) return false;

        _head = (_head + 1) % _capacity;
        _size--;
        return true;
    }

    public bool DeleteLast()
    {
        if (IsEmpty()) return false;

        _tail = (_tail - 1 + _capacity) % _capacity;
        _size--;
        return true;
    }

    public int GetFront() => IsEmpty() ? -1 : _data[_head];

    public int GetRear()
    {
        if (IsEmpty()) return -1;
        return _data[(_tail - 1 + _capacity) % _capacity];
    }

    public bool IsEmpty() => _size == 0;

    public bool IsFull() => _size == _capacity;
}
