namespace DSA.Structures.LinkedList;

public class MyLinkedList<T>
{
    private Node? _head;
    private Node? _tail;
    private int _count;


    public void AddFirst(T value)
    {
        var newNode = new Node(value);
        newNode.Next = _head;
        _head = newNode;
        _tail = _tail == null ? newNode : _tail;
        _count++;
    }

    public void AddLast(T value)
    {
        if (_count == 0)
        {
            AddFirst(value);
            return;
        }
        var newNode = new Node(value);
        _tail!.Next = newNode;
        _tail = newNode;
        _count++;
    }

    public void InsertAt(int index, T value)
    {
        if (index < 0 || index > _count) throw new ArgumentOutOfRangeException();
        if (index == 0)
        {
            AddFirst(value);
            return;
        }

        if (index == _count)
        {
            AddLast(value);
            return;
        }

        var prevNode = GetNodeAt(index - 1);
        var newNode = new Node(value);
        
        newNode.Next = prevNode!.Next;
        prevNode.Next = newNode;
        _count++;
    }

    public void RemoveFirst()
    {
        if(_count == 0) throw new InvalidOperationException();
        if (_count == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head = _head!.Next;
        }
        
        _count--;
    }

    public void RemoveLast()
    {
        if(_count == 0) throw new InvalidOperationException();
        
        if (_count == 1)
        {
            RemoveFirst();
            return;
        }
        
        var prevNode = GetNodeAt(_count - 2);
        
        _tail = prevNode;
        _tail!.Next = null;
        _count--;

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
        
        var prevNode = GetNodeAt(index - 1);

        prevNode!.Next = prevNode!.Next!.Next;
        _count--;

    }

    private Node GetNodeAt(int index)
    {
        var prevNode = _head;
        var currentIndex = 0;
        
        while (currentIndex < index)
        {
            prevNode = prevNode!.Next;
            currentIndex++;
        }

        return prevNode!;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > _count - 1) throw new ArgumentOutOfRangeException();
            return GetNodeAt(index).Data;
        }
    }
    
    private class Node(T data, Node? next = null)
    {
        public T Data = data;
        public Node? Next = next;
    }
    
    
}