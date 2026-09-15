namespace DSA.Algorithms.Arrays;

public static class PrefixSum
{
    public static int[] BuildPrefixSum(int[] arr)
    {
        int[] prefixSum = new int[arr.Length];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        { 
            sum+= arr[i];
            prefixSum[i] = sum;
        }
        return prefixSum;
    }

    public static int GetRangeSum(int[] prefixSumArray, int left, int right)
    {
        int behindLeft = left == 0 ? 0 : prefixSumArray[left - 1];
        return prefixSumArray[right] - behindLeft;
    }
}