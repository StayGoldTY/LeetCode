namespace LeetCode;

public class Q1281
{
    //通过取模来处理
    public static int SubtractProductAndSum(int n)
    {
        var sum = 0;
        var product = 1;
        while (n > 0)
        {
            sum += n % 10;
            product *= n % 10;
            n /= 10;
        }

        return product - sum;
    }

    //通过转换成字符串来处理
    public static int SubtractProductAndSum1(int n)
    {
        var strNum = n.ToString();
        var sum = 0;
        var product = 1;
        for (int i = 0; i < strNum.Length; i++)
        {
            sum += (strNum[i] - '0');
            product *= (strNum[i] - '0');
        }
        return product - sum;
    }
}