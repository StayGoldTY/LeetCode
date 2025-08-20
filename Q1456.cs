namespace LeetCode;

public class Q1456
{
    //灵神的算法思路学习，用单次循环来解决
    public static int MaxVowels(string s, int k) {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int max = 0;
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i])) count++;
            if (i < k - 1)
            {
                continue;
            }
            max = Math.Max(max, count);
            if (vowels.Contains(s[i - k + 1])) count--;
        }
        return max;
    }
    
    //自己的解法，前期维护了一个固定的滑动窗口，但是多了一个循环
    public static int MaxVowels1(string s, int k) {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int max = 0;
        int count = 0;
        for (int j = 0; j < k; j++)
        {
                
            if (vowels.Contains(s[j]))
            {
                count++;
            }
                
        }
        max = Math.Max(max, count);
        for (int i = 1; i < s.Length - k + 1; i++)
        {
            if (vowels.Contains(s[i - 1])) count--;
            if (vowels.Contains(s[i + k - 1])) count++;
            max = Math.Max(max, count);
        }
        return max;
    }
}