namespace LeetCode;

public class Q1512 {

    private void test()
    {
        
    }
    
    public void test1()
    {
        test();
    }
    
    
    
    public static int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int matchNum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                matchNum = matchNum + dict[nums[i]];
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }


        return matchNum;
    }

    
    public static int NumIdenticalPairs1(int[] nums) {
        //Dictionary<int, int> dict = new Dictionary<int, int>();
        int matchNum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    matchNum++;
                }
            }
        }
        return matchNum;
    }
}