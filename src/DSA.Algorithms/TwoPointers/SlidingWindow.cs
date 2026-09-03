namespace DSA.Algorithms.TwoPointers;

public class SlidingWindow
{
 
    public static int LongestSubstringLength(string str)
    {
        // "abbcasa"
        int left = 0;
        int right = 0;
        var hashTable = new Dictionary<char, int>();
        int longestLength = 0;
    
        while (right < str.Length)
        {
            if (hashTable.ContainsKey(str[right]) && hashTable[str[right]] >= left )
            {
                left = hashTable[str[right]] + 1;
            }
        
            longestLength = (longestLength > (right - left) + 1) ? longestLength : (right - left) + 1;
            hashTable[str[right]] = right;
        
            right++;
        }

        return longestLength;
    }
}