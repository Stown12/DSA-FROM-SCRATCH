using DSA.Structures.LinkedList;

namespace DSA.Tests.Structures.LinkedList;

public class MyDoublyLinkedListTests
{
    
    // Nomenclatura de nombre de metodos: Metodo - Escenario - Resultado
    [Fact]
    public void AddFirst_OneNode_NodeAdded()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        
        // Act
        doublyLinkedList.AddFirst(4);
        var firstNode = doublyLinkedList[0];
        
        // Assert
        Assert.Equal(4, firstNode);
    }

    [Fact]
    public void AddLast_TwoNodes_NodeAdded()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddLast(1);
        
        // Act
        doublyLinkedList.AddLast(2);
        var lastNode = doublyLinkedList[1];
        
        // Assert
        Assert.Equal(2, lastNode);
    }
    
    [Fact]
    public void InsertAt_ValidIndex_NodeInserted()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(4);
        
        // Act
        doublyLinkedList.InsertAt(2, 3);
        var nodeAded = doublyLinkedList[2];
        
        // Assert
        Assert.Equal(3, nodeAded);
    }

    [Fact]
    public void InsertAt_InvalidIndex_ExceptionThrown()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(1);
        doublyLinkedList.AddLast(2);
        
        // Act and Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => doublyLinkedList.InsertAt(10, 20));
        
    }

    [Fact]
    public void RemoveFirst_3Nodes_2RemainingNodes()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        
        // Act
        doublyLinkedList.RemoveFirst();
        var firstNode = doublyLinkedList[0];
        // Assert
        
        Assert.Equal(2, firstNode);
    }

    [Fact]
    public void RemoveFirst_EmptyList_ThrowsException()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        
        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => doublyLinkedList.RemoveFirst());
    }
    
    [Fact]
    public void RemoveLast_3Nodes_2RemainingNodes()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        
        // Act
        doublyLinkedList.RemoveLast();
        var lastNode = doublyLinkedList[1];
        // Assert
        
        Assert.Equal(2, lastNode);
    }

    [Fact]
    public void RemoveLast_EmptyList_ThrowsException()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        
        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => doublyLinkedList.RemoveLast());
    }

    [Fact]
    public void AddFirst_FiveNodes_VerifyPrevPointerIsWorking()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(5);
        doublyLinkedList.AddFirst(4);
        doublyLinkedList.AddFirst(3);
        doublyLinkedList.AddFirst(2);
        doublyLinkedList.AddFirst(1);
        
        // Act
        doublyLinkedList.RemoveLast();
        var lastNode = doublyLinkedList[3];
        
        // Assert
        Assert.Equal(4, lastNode);
    }
    
    [Fact]
    public void RemoveAt_ValidIndex_NodeRemoved()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        doublyLinkedList.AddLast(4);
        
        // Act
        doublyLinkedList.RemoveAt(2);
        var nodeAtIndex2 = doublyLinkedList[2];
        Assert.Equal(4, nodeAtIndex2);
        
    }

    [Fact]
    public void RemoveAt_InvalidIndex_ExceptionThrown()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        
        // Act and Arrange
        Assert.Throws<ArgumentOutOfRangeException>(() => doublyLinkedList.RemoveAt(-1));
    }

    [Fact]
    public void Contains_ExistingValue_True()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        
        // Act and Assert
        Assert.True(doublyLinkedList.Contains(3)); 
    }
    
    [Fact]
    public void Contains_NotExistingValue_False()
    {
        // Arrange
        var dobDoublyLinkedList = new MyDoublyLinkedList<int>();
        dobDoublyLinkedList.AddLast(1);
        
        // Act and Assert
        Assert.False(dobDoublyLinkedList.Contains(4));
        
    }

    [Fact]
    public void Contains_EmptyList_False()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        
        // Act and Assert
        
        Assert.False(doublyLinkedList.Contains(0));
    }

    [Fact]
    public void ToArray_ListWithElements_ArrayWithElements()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        doublyLinkedList.AddFirst(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        
        // Act
        var listToArray = doublyLinkedList.ToArray();
        
        // Assert
        Assert.Equal([1,2,3], listToArray);
    }

    [Fact]
    public void ToArray_EmptyList_ArrayWithoutElements()
    {
        // Arrange
        var doublyLinkedList = new MyDoublyLinkedList<int>();
        
        // Act
        var listToArray = doublyLinkedList.ToArray();
        
        // Assert
        Assert.Empty(listToArray);
    }

}