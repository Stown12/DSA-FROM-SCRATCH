using DSA.Algorithms.TwoPointers;

namespace DSA.Algorithms;

public static class Program
{

    public static void Main()
    {
        var result = TwoPointerProblems.TwoSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10);
        Console.WriteLine($"Sum: {result.Item1}, Indices: {result.Item2}");
    }
}
