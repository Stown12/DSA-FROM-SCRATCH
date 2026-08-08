using DSA.Algorithms.Searching;
using DSA.Structures.Linear;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [5,10];
        int index = BinarySearch.Search(numbers, 7);

        Console.WriteLine($"Index encontrado: {index}");
    }
}