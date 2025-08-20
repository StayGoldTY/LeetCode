namespace LeetCode;

public class Q258
{
    
    //递归解法1
    public static int AddDigits1(int num)
    {
        string numStr = num.ToString();
        int numTotle = 0;
        for (int i = numStr.Length - 1; i >= 0; i--)
        {
            numTotle  = numTotle + (numStr[i] - '0');
        }

        while (numTotle >=  10)
        {
            numTotle = AddDigits(numTotle);
        }
        
        return numTotle;
    }
    
    //递归解法优化
    public static int AddDigits2(int num)
    {

        if (num < 10) return num;
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        
        return AddDigits(sum);
    }
    
    //不用递归和循环，时间复杂度O(1)
    public static int AddDigits3(int num)
    {
        if (num < 10) return num;
        int reminder = num % 9;
        if (reminder == 0) return 9; 
        var ret = num % 9;
        return ret;
    }
    
    public static int AddDigits(int num)
    {
        var ret = (num -1) % 9 + 1;
        return ret;
    }
}