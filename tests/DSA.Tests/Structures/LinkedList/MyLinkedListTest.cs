using DSA.Structures.Linear;
using DSA.Structures.LinkedList;

namespace DSA.Tests.Structures.LinkedList;

public class MyLinkedListTest
{
    
    // Nomenclatura de nombre de metodos: Metodo - Escenario - Resultado
    [Fact]
    public void AddFirst_OneNode_NodeAdded()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        
        // Act
        linkedList.AddFirst(4);
        var firstNode = linkedList[0];
        
        // Assert
        Assert.Equal(4, firstNode);
    }

    [Fact]
    public void AddLast_TwoNodes_NodeAdded()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddLast(1);
        
        // Act
        linkedList.AddLast(2);
        var lastNode = linkedList[1];
        
        // Assert
        Assert.Equal(2, lastNode);
    }
    
    [Fact]
    public void InsertAt_ValidIndex_NodeInserted()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        linkedList.AddLast(4);
        
        // Act
        linkedList.InsertAt(2, 3);
        var nodeAded = linkedList[2];
        
        // Assert
        Assert.Equal(3, nodeAded);
    }

    [Fact]
    public void InsertAt_InvalidIndex_ExceptionThrown()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        
        // Act and Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.InsertAt(10, 20));
        
    }

    [Fact]
    public void RemoveFirst_3Nodes_2RemainingNodes()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        
        // Act
        linkedList.RemoveFirst();
        var firstNode = linkedList[0];
        // Assert
        
        Assert.Equal(2, firstNode);
    }

    [Fact]
    public void RemoveFirst_EmptyList_ThrowsException()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        
        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => linkedList.RemoveFirst());
    }
    
    [Fact]
    public void RemoveLast_3Nodes_2RemainingNodes()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        
        // Act
        linkedList.RemoveLast();
        var lastNode = linkedList[1];
        // Assert
        
        Assert.Equal(2, lastNode);
    }

    [Fact]
    public void RemoveLast_EmptyList_ThrowsException()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        
        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => linkedList.RemoveLast());
    }
    
    [Fact]
    public void RemoveAt_ValidIndex_NodeRemoved()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);
        
        // Act
        linkedList.RemoveAt(2);
        var nodeAtIndex2 = linkedList[2];
        Assert.Equal(4, nodeAtIndex2);
        
    }

    [Fact]
    public void RemoveAt_InvalidIndex_ExceptionThrown()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        
        // Act and Arrange
        Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.RemoveAt(-1));
    }

    [Fact]
    public void Contains_ExistingValue_True()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        
        // Act and Assert
        Assert.True(linkedList.Contains(3)); 
    }
    
    [Fact]
    public void Contains_NotExistingValue_False()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddLast(1);
        
        // Act and Assert
        Assert.False(linkedList.Contains(4));
        
    }

    [Fact]
    public void Contains_EmptyList_False()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        
        // Act and Assert
        
        Assert.False(linkedList.Contains(0));
    }

    [Fact]
    public void ToArray_ListWithElements_ArrayWithElements()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        
        // Act
        var listToArray = linkedList.ToArray();
        
        // Assert
        Assert.Equal([1,2,3], listToArray);
    }

    [Fact]
    public void ToArray_EmptyList_ArrayWithoutElements()
    {
        // Arrange
        var linkedList = new MyLinkedList<int>();
        
        // Act
        var listToArray = linkedList.ToArray();
        
        // Assert
        Assert.Empty(listToArray);
    }
}