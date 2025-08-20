namespace LeetCode.Kata;

public class FreqArr
{
    public static int[] FreqArrKata(int[] arr)
    {
        var maxVal = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxVal) maxVal = arr[i];
        }
        int[] freq = new int[maxVal + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            freq[arr[i]]++;
        }
        return freq;
    }
}