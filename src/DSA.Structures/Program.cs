using DSA.Algorithms.Searching;
using DSA.Algorithms.TwoPointers;
using DSA.Structures.Linear;

public class Program
{
    public static void Main(string[] args)
    {
        var result = TwoPointerProblems.TwoSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2);
        Console.WriteLine($"Sum: {2}: index 1: {result.left}, index 2: {result.right}");
    }
}