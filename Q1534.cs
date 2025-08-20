namespace LeetCode;

public class Q1534
{
    public void FreqSum()
    {
        var arr = new int[5];
        var sum = new int[6];
        for (int i = 0; i < arr.Length + 1; i++)
        {
            sum[i] = sum[i - 1] + arr[i];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr[i]; i < arr.Length + 1; j++)
            {
                sum[j]++;
            }
        }
        
        
        
    }
    //频次数组结合前缀和组合解法
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var ret = 0;
        int[] freq = new int[1001];
        int[]  sum = new int[1001];
        for (int j = 0; j < arr.Length ; j++)
        {
            for (int k = j + 1; k < arr.Length; k++)
            {
                if (Math.Abs(arr[j] - arr[k]) <= b)
                {
                    var l1 = arr[j] - a;
                    var r1 = arr[j] + a;
                    var l2 = arr[k] - c;
                    var r2 = arr[k] + c;
                    var maxL = Math.Max(0,Math.Max(l1, l2));
                    var minR = Math.Min(1000,Math.Min(r1, r2));
                    if (maxL <= minR)
                    {
                        if (maxL == 0)
                        {
                            ret = ret + sum[minR];
                        }else
                        {
                            ret = ret + sum[minR] - sum[maxL - 1];
                        }
                    }
                }
            }
            freq[arr[j]]++; // 更新频率数组
            sum[0] = freq[0];
            for (int i = 1; i < 1001; i++)
            {
                sum[i] = sum[i - 1] + freq[i];
            }
            
            // for (int i = arr[j]; i < 1001; i++)
            // {
            //     sum[i]++;
            // }
        }
        return ret;
    }

    //暴力解法
    public int CountGoodTriplets1(int[] arr, int a, int b, int c)
    {
        int num = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        // Console.WriteLine(arr[i]);
                        // Console.WriteLine(arr[j]);
                        // Console.WriteLine(arr[k]);
                        num++;
                    }
                }
            }
        }
        return num;
    }
}