using DSA.Algorithms.TwoPointers;

namespace DSA.Tests.Algorithms.TwoPointers;

public class TwoSumTest
{
    [Fact]
    public void Sum_TwoItem_GetIndexes()
    {
        // Arrange
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        
        // Act
        var result = TwoPointerProblems.TwoSum(arr, 10);
        
        // Assert
        Assert.Equal((0, 8), result);
    }

    [Fact]
    public void Sum_TwoItem_GetNotFound()
    {
        // Arrange
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        
        // Act
        var result = TwoPointerProblems.TwoSum(arr, 2);
        
        // Assert
        Assert.Equal((-1, -1), result);
    }

    [Fact]
    public void Sum_TwoItem_GetNegativeIndexes()
    {
        // Arrange
        int[] arr = [-10, -8, -4, 0, 2, 4, 7, 8, 9];
        
        // Act
        var result = TwoPointerProblems.TwoSum(arr, 0);
        
        // Assert
        Assert.Equal((1, 7), result);
    }
}