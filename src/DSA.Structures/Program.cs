using DSA.Algorithms.Arrays;
using DSA.Algorithms.Searching;
using DSA.Algorithms.TwoPointers;
using DSA.Structures.Linear;

public class Program
{
    public static void Main(string[] args)
    {
        var prefixSumArray = PrefixSum.BuildPrefixSum(new int[] { 1, 2, 3, 4, 5, });

        foreach (var array in prefixSumArray)
        {
            Console.Write(array + " ");
        }
        Console.WriteLine();

        var rangeSum = PrefixSum.GetRangeSum(prefixSumArray, 1, 3);
        Console.WriteLine("Range sum: " + rangeSum);
    }
}