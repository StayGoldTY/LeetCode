namespace LeetCode;

public class Q1470
{
    //自己认为清楚的写法
    public static int[] Shuffle(int[] nums, int n) {
        var newNums = new int[2* n];
        var j = 0;
        var b = n;
        for (int i = 0; i < 2 * n; i = i + 1)
        {
            newNums[i] = i % 2 == 0 ? nums[j++] : nums[b++];
        }
        return newNums;
    }
    //自己的解法
    public static int[] Shuffle1(int[] nums, int n) {
        var newNums = new int[2* n];
        int j = 0;
        for (int i = 0; i < 2 * n; i = i + 2)
        {
            
            newNums[i] = nums[i - j];
            newNums[i + 1] = nums[i -j + n];
            j++;

        }
        return newNums;
    }
}