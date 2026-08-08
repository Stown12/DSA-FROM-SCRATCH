namespace DSA.Algorithms.Searching;

public static class BinarySearch
{
    public static int Search(int[] array, int target)
    {
        int rigth = array.Length - 1;
        int left = 0;
        
        while (left <= rigth)
        {
            int mid = (left + rigth) / 2;

            if (array[mid] < target)
            {
                left = mid + 1;
            }else if (array[mid] > target)
            {
                rigth = mid - 1;
            }
            else
            {
                return mid;
            }
            
        }

        return -1;
    }

    public static int SearchRecursive(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        return SearchRecursive(array, target, left, right);
    }
    
    private static int SearchRecursive(int[] array, int target, int left, int right)
    {
        if (left > right)
            return -1;
        
        
        int mid = (left + right) / 2;

        if (array[mid] < target)
        {
            return SearchRecursive(array, target,mid + 1, right);
        }
        if (array[mid] > target)
        {
            return SearchRecursive(array, target, left,mid - 1);
        }

        return mid;

    }
}