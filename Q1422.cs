namespace LeetCode;

public class Q1422
{
    //更加直观的思路
    //我们计算出左边的0最多比1多上多少的情况，其实就是一个最好的分割点
    //在这个分割点的情况下左边的0是最多的，1是最少的，也就是右边的1是最多的
    public static int MaxScore(string s)
    {
        int score = 0;

        int max = 0;
        for (int j = 1; j < s.Length - 1; j++)
        {
            if (s[j] - '0' == 0)
            {
                score++;
            }
            else
            {
                score--;
            }
            max = Math.Max(score, max);
        }
        //下面推理总共有多少1
        //先假设x是0的数量，y为1的数量score = x - y
        //同时很显然s.length - 2 = x + y;
        //得到2y = s.length - 2 -score  y = (s.length -2 -score) /2
        int y = (s.Length - 2 - score) / 2;
        //同时我们得到的max相当于是左边的0 的数量-左边的1的数量，而我们实际要得到的是左边的0 + 右边的1的数量
        //右边的1的数量，其实等于总的1的数量减去左边的0的数量
        //所以可以得到是y + max就是最后的值，也就是左边的0 + 总的1 - 左边的1 = 左边的0 + 右边的1
        max = y + max;
        if (s[0] == '0') max++;
        if (s[s.Length - 1] == '1') max++;
        return max;
    }
    //一次遍历的优化解法
    public static int MaxScore4(string s)
    {
        int score0 = 0;
        int score1 = 0;
        int max = 0;
        for (int j = 0; j < s.Length - 1; j++)
        {
            if(s[j] - '0' ==1) score1++; //统计所有的1的数量
            if (s[j] == '0')
            {
                score0++;
            }
            else
            {
                score0--;
            }
            max = Math.Max(max, score0); //统计最大的0的数量
        }
        int last = s[s.Length - 1] == 0 ? 0 : 1;
        return max +  score1 + last;
    }
    
    //官方写法2，类似于滑动窗口的方式
    public static int MaxScore3(string s)
    {

        int score = 0;
        for (int i = 0; i < s.Length; i++)
        {
           if(s[i] - '0' ==1) score++;
        }

        int max = 0;
        for (int j = 0; j < s.Length - 1; j++)
        {
            if (s[j] == '0')
            {
                score++;
            }
            else
            {
                score--;
            }
            max = Math.Max(max, score);
        }
        return max;
    }
    //官方写法1
    public static int MaxScore2(string s)
    {
        var max = 0;
        for (int i = 1; i < s.Length; i++)
        {
            int score = 0;
            for (int j = 0; j < i; j++)
            {
                if(s[j] == '0') score++;
            }

            for (int j = i; j < s.Length; j++)
            {
                if(s[j] == '1') score++;
            }
            max =  max > score ? max : score;
        }
        return max;
    }
    //自己的写法
    public static int MaxScore1(string s)
    {
        int left = 0, right = 0;
        var max = 0;
        for (int i = 1; i < s.Length; i++)
        {
            left = (s.Substring(0, i)).Count(c => c == '0');
            right = s.Substring(i, s.Length - i).Count(c => c == '1');
            max =  max > left + right ? max : left + right;
        }
        return max;
    }
    
}