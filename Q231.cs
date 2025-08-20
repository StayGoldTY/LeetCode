namespace LeetCode;

public class Q231
{
    //用公约数来处理
    public static bool IsPowerOfTwo(int n)
    {
        int maxTowPowerNum = 1 << 30;
        return n > 0 && maxTowPowerNum % n == 0;
    }
    //位运算解法2
    public static bool IsPowerOfTwo3(int n)
    {
        return n > 0 && (n & (-n)) == n;
    }
    //位运算解法1
    public static bool IsPowerOfTwo2(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
    //使用迭代来解决的
    public static bool IsPowerOfTwo1(int n)
    {
        int begin = 1;
        while (begin is <= int.MaxValue and > 0)
        {
            if (begin == n) return true;
            begin *= 2;
        }
        return false;
    }
}