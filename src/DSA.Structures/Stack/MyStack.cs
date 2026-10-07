using DSA.Structures.LinkedList;

namespace DSA.Structures.Stack;

public class MyStack<T>
{
    private MyDoublyLinkedList<T> _stack = new ();
    public int Count => _stack.Count;
    
    public void Push(T element)
    {
        _stack.AddLast(element);
    }

    public T Pop()
    {
        var element = Peek();
        _stack.RemoveLast();
        return element;
    }

    public T Peek()
    {
        if(_stack.Count == 0) throw new InvalidOperationException("Stack is empty");
        return _stack[_stack.Count - 1];
    }
    
    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }
}