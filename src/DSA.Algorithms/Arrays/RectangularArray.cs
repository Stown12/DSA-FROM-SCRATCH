namespace DSA.Algorithms.Arrays;

public static class RectangularArray
{
    public static int[,] GetRectangularArray()
    {
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = i * 3 + j;
            }
        }

        return matriz;
    }
}