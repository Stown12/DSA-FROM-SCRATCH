using static DSA.Algorithms.Arrays.PrefixSum;
namespace DSA.Tests.Algorithms.Arrays;

public class PrefixSumTest
{
    [Fact]
    public void BuildPrefixSum_ValidInput_ReturnsCorrectPrefixSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 3, 6, 10, 15 };

        // Act
        int[] result = BuildPrefixSum(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetRangeSum_ValidInput_ReturnsCorrectSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] prefixSum = BuildPrefixSum(input);
        int left = 1;
        int right = 3;
        int expected = 9; // 2 + 3 + 4

        // Act
        int result = GetRangeSum(prefixSum, left, right);

        // Assert
        Assert.Equal(expected, result);
    } 
    
    [Fact]
    public void GetRangeSum_LeftIsZero_ReturnsCorrectSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] prefixSum = BuildPrefixSum(input);
        int left = 0;
        int right = 2;
        int expected = 6; // 1 + 2 + 3

        // Act
        int result = GetRangeSum(prefixSum, left, right);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetRangeSum_1ElementRange_ReturnsCorrectSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] prefixSum = BuildPrefixSum(input);
        int left = 2;
        int right = 2;
        int expected = 3; // Only the element at index 2

        // Act
        int result = GetRangeSum(prefixSum, left, right);

        // Assert
        Assert.Equal(expected, result);
    }
}