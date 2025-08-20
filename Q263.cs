namespace LeetCode;

public class Q263
{
    //分解质因数
    public static bool IsUgly(int n)
    {
        if (n <= 0) return false;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;
        return (n & (n - 1)) == 0;
    }
    //暴力解法
    public static bool IsUgly1(int n)
    {
        if (n == 1) return true;
        for (int i = 1; 0< i  && i<= n; i = i * 2)
        {
            Console.WriteLine("i =" + i);
            for (int j = 1;  0< j  &&j <= (n / i); j = j * 3)
            {
                Console.WriteLine("j =" + j);
                for (int k = 1;  0< k  &&k <= n / (i * j); k = k * 5)
                {
                    Console.WriteLine("k =" + k);
                    if (i * j * k == n) return true;
                }
            }
        }
        return false;
    }
}