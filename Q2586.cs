namespace LeetCode;

public class Q2586
{
    //如果字符串以元音字母开头并以元音字母结尾，那么该字符串就是一个 元音字符串 ，其中元音字母是 'a'、'e'、'i'、'o'、'u' 。
    
    
    //暴力解法
    public static int VowelStrings(string[] words, int left, int right) 
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int ret = 0;
        for (int i = left; i < right + 1; i++)
        {
            if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][words[i].Length - 1]))
            {
                ret++;
            }
        }
        return ret;
    }
}