namespace DSA.Algorithms.TwoPointers;

public static class TwoPointerProblems
{
    
    public static (int left, int right) TwoSum(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int sum = arr[left] + arr[right];

            if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                return (left, right);
            }
        }

        return (-1, -1);
    }

    public static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(str[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(str[right]))
            {
                right--;
            }

            if (char.ToUpper(str[left]) != char.ToUpper(str[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }
}