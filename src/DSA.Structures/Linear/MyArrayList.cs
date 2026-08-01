namespace DSA.Structures.Linear;

public class MyArrayList<T>
{
    private T[] _data;
    private int _count;

    public int Count => _count;
    public int Capacity => _data.Length;
    
    public MyArrayList(int initialCapacity = 4)
    {
        _data = new T[initialCapacity];
        _count = 0;
    }

    
    public void Add(T item)
    {
        Resize();
        _data[_count] = item;
        _count++;
    }

    public T this[int index]
    {
        get
        {
            ValidateIndex(index);
            return _data[index];
        }
        set
        {
            ValidateIndex(index);
            _data[index] = value;
        }
    }

    public void RemoveAt(int index)
    {
        ValidateIndex(index);
        for (int i = index; i < _count - 1; i++)
        {
            
            _data[i] = _data[i + 1];
        }
        _data[_count - 1] = default!;
        _count--;
    }

    public void Insert(int index, T item)
    {
        ValidateIndex(index);
        Resize();
        for (int i = _count - 1; i >= index; i--)
        {
            _data[i + 1] = _data[i];
        }
        _data[index] = item;
        _count++;
    }

    public void Clear()
    {
        _count = 0;
        Array.Clear(_data);
    }
    
    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException();
    }

    private void Resize()
    {
        if (_count == _data.Length)
        {
            T[] newArray = new T[_data.Length * 2];
            _data.CopyTo(newArray, 0);
            _data = newArray;
        }
    }

}