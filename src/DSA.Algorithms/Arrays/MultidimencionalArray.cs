namespace DSA.Algorithms.Arrays;

public static class MultidimencionalArray
{
    public static int[][] PascalPiramide()
    {
        int[][] pascal = new int[5][];

        for (int i = 0; i < 5; i++)
        {
            pascal[i] = new int[i + 1];
        }
        return pascal;
    }
}