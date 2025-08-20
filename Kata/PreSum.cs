namespace LeetCode.Kata;

public class PreSum
{
    public static int RangeSum(int[] arr,int l,int r)
    {
        int[] preSum = PreSumKata(arr);
        var ret = 0;
        if (l == 0)
        {
            ret = preSum[r];
        }else
        {
            ret = preSum[r] - preSum[l - 1];
        }
         
        
        int[] preSum1 = PreSumKata1(arr);
        ret =  preSum1[r + 1] - preSum1[l];
        return ret;
    }

    //标准版本
    public static int[] PreSumKata(int[] arr)
    {
        var preSum = new int[arr.Length];
        preSum[0] = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            preSum[i] = preSum[i - 1] + arr[i];
        }
        return preSum;
    }
    //带哨兵版本
    public static int[] PreSumKata1(int[] arr)
    {
        var preSum = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            preSum[i + 1] = preSum[i] + arr[i];
        }
        return preSum;
    }
}