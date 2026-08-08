namespace DSA.Tests.Algorithms.BinarySearch;
using DSA.Algorithms.Searching;


public class BinarySearchRecursiveTest
{
    [Fact]
    public void Search_OneItem_GetItemIndex()
    {
        // Arrange
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        
        // Act
        int item = BinarySearch.SearchRecursive(numbers, 5);
        
        // Assert
        Assert.Equal(4, item);
    }

    [Fact]
    public void Search_OneItem_GetNotFound()
    {
        // Arrange
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        
        // Act
        int item = BinarySearch.SearchRecursive(numbers, 99);
        
        // Assert
        Assert.Equal(-1, item);
    }


    [Fact]
    public void Search_InEmptyArray_GetNotFound()
    {
        // Arrange
        int[] numbers = [];
        
        // Act
        int item = BinarySearch.SearchRecursive(numbers, 0);
        
        // Assert
        Assert.Equal(-1, item);
    }
}