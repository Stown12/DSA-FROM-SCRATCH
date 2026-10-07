using DSA.Structures.Stack;

namespace DSA.Tests.Stack;

public class MiStackTests
{
    [Fact]
    public void Push_OneElement_ElementAdded()
    {
        // Arrange
        var myStack = new MyStack<int>();
        
        // Act
        myStack.Push(1);
        
        // Assert
        Assert.Equal(1, myStack.Peek());
    }

    [Fact]
    public void Pop_TwoElements_ReturnsLastPushed()
    {
        // Arrange
        var myStack = new MyStack<int>();
        
        // Act
        myStack.Push(1);
        myStack.Push(2);
        var popped = myStack.Pop();
        
        // Assert
        Assert.Equal(2, popped);
        Assert.Equal(1, myStack.Count);
    }
    
    [Fact]
    public void Peek_EmptyStack_ExceptionThrown()
    {
        // Arrange
        var myStack = new MyStack<int>();
        
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => myStack.Peek());
    }

    [Fact]
    public void IsEmpty_EmptyStack_True()
    {
        // Arrange
        var myStack = new MyStack<int>();
        
        // Act
        var isEmpty = myStack.IsEmpty();
        
        // Assert
        Assert.True(isEmpty);
    }
    
    [Fact]
    public void IsEmpty_StackWithOneElement_False()
    {
        // Arrange
        var myStack = new MyStack<int>();
        
        // Act
        myStack.Push(1);
        var isEmpty = myStack.IsEmpty();
        
        // Assert
        Assert.False(isEmpty);
    }
}