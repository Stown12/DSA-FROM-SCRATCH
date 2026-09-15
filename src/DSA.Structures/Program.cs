using DSA.Algorithms.Arrays;
using DSA.Algorithms.Searching;
using DSA.Algorithms.TwoPointers;
using DSA.Structures.Linear;

public class Program
{
    public static void Main(string[] args)
    {
        var rectangularArray = RectangularArray.GetRectangularArray();

        for (int i = 0; i < rectangularArray.GetLength(0); i++)
        {
            for (int j = 0; j < rectangularArray.GetLength(1); j++)
            {
                Console.Write(rectangularArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}