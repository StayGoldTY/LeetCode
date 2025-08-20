namespace LeetCode;

public class Q852
{
    //经典二分
    //经典二分有一个关键就是对于临界值就是mid的处理
    public static int PeakIndexInMountainArray(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;
        int mid = 0;
        while (left <= right)
        {
            mid =   (right + left) / 2;
            // 如果 m 是峰值
            if (arr[mid] >= arr[mid - 1] && arr[mid] >= arr[mid + 1]) {
                return mid;
            }
            
            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }
        }
        return mid;
    }
    //简洁二分
    public static int PeakIndexInMountainArray3(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;
        int mid = 0;
        while (left < right)
        {
             mid = left + (right - left) / 2;
            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
            
        }

        return left;


    }

    //官方枚举方法，直接找到最大的数
    //但是这个条件和官方说的必须是O(log(n))不匹配，应是o(n)
    public static int PeakIndexInMountainArray2(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) return i;
        }

        return 1;

    }

    //本质上就是要二分查找，暴力递归二分
    //先查找中间的一个元素，然后比较这个元素相邻的元素
    //如果是左边的元素大于改元素，那么说明最大的数在左边，重复二分
    //同理右边的也是一样
    public static int PeakIndexInMountainArray1(int[] arr) {
        int n = arr.Length;
        int mid  = n / 2;
        Console.WriteLine("mid = " + mid);
        int value = arr[mid];
        int left = value,right = value;
        if (mid > 0)
        {
            left = arr[mid - 1];
        }
        if (mid < n - 1)
        {
             right = arr[mid + 1];
        }

        if (value >= left && value >= right) return mid;

        if (value < left)
        {
            var ints = arr[0..mid ];
            return PeakIndexInMountainArray(ints);
        }

        if (value > left)
        {
            var ints = arr[(mid + 1)..n ];
            return PeakIndexInMountainArray(ints) + mid + 1;
        }
        return mid;
    }
}