namespace LeetCode;

public class Q326
{
    
    //最大公约数解法
    public static bool IsPowerOfThree(int n)
    {
        int max = 1162261467;
        return n > 0 && max % n == 0;
    }
    //暴力解法
    public static bool IsPowerOfThree1(int n)
    {
        int begin = 1;
        while (begin > 0)
        {
            if (begin  == n) return true;
            begin *= 3;
        }
        return false;
    }
}