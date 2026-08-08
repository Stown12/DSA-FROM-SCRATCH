using DSA.Structures.Linear;

namespace DSA.Tests.Structures.Arrays;

public class MyArrayListTests
{
    MyArrayList<int> _arrayList;
    
    public MyArrayListTests()
    {
        _arrayList = new MyArrayList<int>(5);
    }

    [Fact]
    public void Add_ManyItems_GrowArray()
    {
        // Arrange
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        _arrayList.Add(5);
        _arrayList.Add(6);
        
        // Assert
        Assert.Equal(6, _arrayList.Count);
        Assert.Equal(10, _arrayList.Capacity);
    }
    
    [Fact]
    public void Add_TenThousandItems_MaintainsIntegrity()
    {
        for (int i = 0; i < 10_000; i++)
            _arrayList.Add(i);

        Assert.Equal(10_000, _arrayList.Count);
        Assert.Equal(0, _arrayList[0]);
        Assert.Equal(9_999, _arrayList[9_999]);
    }
    
    [Fact]
    public void Remove_OneItem_DownArray()
    {
        // Arrange
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        
        // Act
        _arrayList.RemoveAt(0);
        
        // Assert
        Assert.Equal(2, _arrayList[0]);
        Assert.Equal(3, _arrayList.Count);
        
        
    }

    [Fact]
    public void Insert_OneItem_GrowArray()
    {
        // Arrange
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        
        // Act
        _arrayList.Insert(2, 99);
        
        // Assert
        Assert.Equal(99, _arrayList[2]);
        Assert.Equal(5, _arrayList.Count);
    }
    [Fact]
    public void RemoveAt_InvalidIndex_ThrowsException()
    {
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        
        Assert.Throws<IndexOutOfRangeException>( () => _arrayList.RemoveAt(99));
    }
    
    [Fact]
    public void InsertAt_InvalidIndex_ThrowsException()
    {
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        
        Assert.Throws<IndexOutOfRangeException>(() => _arrayList.Insert(99, 3));
    }
    
    [Fact]
    public void Get_InvalidIndex_ThrowsException()
    {
        _arrayList.Add(1);
        _arrayList.Add(2);
        _arrayList.Add(3);
        _arrayList.Add(4);
        
        Assert.Throws<IndexOutOfRangeException>(() => _arrayList[99]);
    }
    
    
}