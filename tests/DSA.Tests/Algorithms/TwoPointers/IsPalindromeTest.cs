using DSA.Algorithms.TwoPointers;

namespace DSA.Tests.Algorithms.TwoPointers;

public class IsPalindromeTest
{
    [Fact]
    public void IsPalindrome_SingleString_ReturnsTrue()
    {
        // Arrange
        string input = "A man, a plan, a canal: Panama";
        
        // Act
        bool result = TwoPointerProblems.IsPalindrome(input);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_SingleString_ReturnsFalse()
    {
        // Arrange
        string input = "no es un palindromo";
        
        // Act
        bool result = TwoPointerProblems.IsPalindrome(input);
        
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPalindrome_EmptyString_ReturnsTrue()
    {
        // Arrange
        string input = "";
        
        // Act
        bool result = TwoPointerProblems.IsPalindrome(input);
        
        // Assert
        Assert.True(result);
    }
}