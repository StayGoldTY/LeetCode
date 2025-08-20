namespace LeetCode;

public class Q643
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        double max =int.MinValue;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(i < k -1) continue;
            max = Math.Max(max, sum) ;
            sum -= nums[i - k + 1];
        }
        
        return max/ k;
    }
}