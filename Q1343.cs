namespace LeetCode;

public class Q1343
{
    public static int NumOfSubarrays(int[] arr, int k, int threshold) {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if(i < k -1) continue;  
            if (sum / k >= threshold) count++;
            sum -= arr[i - k + 1];
        }
        return count;
    }
}