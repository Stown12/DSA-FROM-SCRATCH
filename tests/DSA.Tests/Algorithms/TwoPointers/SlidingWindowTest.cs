using DSA.Algorithms.TwoPointers;

namespace DSA.Tests.Algorithms.TwoPointers;


public class SlidingWindowTest
{
    [Fact]
    public void LongestSubstringLength_EmptyString_ReturnsZero()
    {
        // Arrange
        string str = string.Empty;
        
        // Act
        var result = SlidingWindow.LongestSubstringLength(str);
        
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void LongestSubstringLength_String_ReturnsLength()
    {
        // Arrange
        string str = "Hello World";
        
        // Act
        var result = SlidingWindow.LongestSubstringLength(str);
        
        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void LongestSubstringLength_SameString_ReturnsOne()
    {
        // Arrange
        string str = "aaaaaaaaaa";
        
        // Act
        var result = SlidingWindow.LongestSubstringLength(str);
        
        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void LongestSubstringLength_NonRepetingString_ReturnsLength()
    {
        // Arrange
        string str = "asdfghjklñ";
        
        // Act
        var result = SlidingWindow.LongestSubstringLength(str);
        
        // Assert
        Assert.Equal(str.Length, result);
    }
}