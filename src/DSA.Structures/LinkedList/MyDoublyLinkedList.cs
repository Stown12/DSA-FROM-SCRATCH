namespace DSA.Structures.LinkedList;

public class MyDoublyLinkedList<T>
{
    private Node? _head;
    private Node? _tail;
    private int _count;
    public int Count => _count;

    public void AddFirst(T data)
    {
        var newNode = new Node(data);
        newNode.Next = _head;

        _head?.Prev = newNode;

        _head = newNode;
        _tail = _tail == null ? newNode : _tail;

        _count++;
    }

    public void AddLast(T data)
    {
        if (_count == 0)
        {
            AddFirst(data);
            return;
        }

        var newNode = new Node(data);
        newNode.Prev = _tail;
        _tail!.Next = newNode;
        _tail = newNode;
        _count++;
    }

    public void RemoveFirst()
    {
        if (_head == null) throw new InvalidOperationException();

        if (_count == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head = _head.Next;
            _head!.Prev = null;
        }

        _count--;
    }

    public void RemoveLast()
    {
        if (_head == null) throw new InvalidOperationException();

        if (_count == 1)
        {
            RemoveFirst();
            return;
        }

        var prevNode = _tail!.Prev;
        _tail.Prev = null;
        _tail = prevNode;
        _tail!.Next = null;
        _count--;
    }

    public void InsertAt(int index, T data)
    {
        if(index < 0 || index > _count) throw new ArgumentOutOfRangeException();

        if (index == 0)
        {
            AddFirst(data);
            return;
        }

        if (index == _count)
        {
            AddLast(data);
            return;
        }
        
        var prevNode = GetNodeAt(index - 1);
        var newNode = new Node(data);
        var nextNode = prevNode.Next;
        newNode.Next = prevNode.Next;
        newNode.Prev = prevNode;
        prevNode.Next = newNode;
        nextNode!.Prev = newNode;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if(index < 0 || index > _count - 1) throw new ArgumentOutOfRangeException();

        if (index == 0)
        {
            RemoveFirst();
            return;
        }

        if (index == _count - 1)
        {
            RemoveLast();
            return;
        }
        var node = GetNodeAt(index);
        node.Prev!.Next = node.Next;
        node.Next!.Prev = node.Prev;
        node.Next = null;
        node.Prev = null;
        _count--;
    }

    public T this[int index]
    {
        get
        {
            if(index < 0 || index > _count - 1) throw new ArgumentOutOfRangeException();
            return GetNodeAt(index).Data;
        }
    }

    public T[] ToArray()
    {
        
        T[] array = new T[_count];
        var node = _head;
        var currentIndex = 0;

        while (node != null)
        {
            array[currentIndex] = node.Data;
            node = node.Next;
            currentIndex++;
        }
        
        return array;
    }

    public bool Contains(T value)
    {
        var node = _head;

        while (node != null)
        {
            if (Equals(node.Data, value)) return true;
            node = node.Next;
        }
        
        return false;
    }

    private Node GetNodeAt(int index)
    {

        Node? prevNode;
        int currentIndex;
        if (index < _count / 2)
        {
            prevNode =  _head;
            currentIndex = 0;
            while (currentIndex < index)
            {
                prevNode = prevNode!.Next;
                currentIndex++;
            }
            return prevNode!;
        }

        prevNode = _tail;
        currentIndex = _count - 1;

        while (currentIndex > index)
        {
            prevNode = prevNode!.Prev;
            currentIndex--;
        }

        return prevNode!;

    }


    private class Node(T data, Node? next = null, Node? prev = null)
    {
        public T Data = data;
        public Node? Next = next;
        public Node? Prev = prev;
    }
}