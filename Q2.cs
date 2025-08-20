using System.ComponentModel;
using System.Globalization;
using System.Numerics;

namespace LeetCode;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Q2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode current = null;
        var carry = 0;
        while (l1 != null || l2 != null)
        {
            
            l1 =   l1 ?? new ListNode();
            l2 = l2 ?? new ListNode();
            
            var sum = l1.val + l2.val + carry;
            
            carry = sum / 10;

            
            if (head == null)
            {
                head = new ListNode(sum % 10);
                current = head;
            }
            else
            {
                current.next = new ListNode(sum % 10);
                current = current.next;
            }

          
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }
        
        
        
        
        
        return head;
    }
    public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
    {
        BigInteger l1Num = 0;
        BigInteger l2Num = 0;
        int i = 0;
        int j = 0;

        while (l1 != null)
        {
            BigInteger plusPamarm = (BigInteger)(l1.val * BigInteger.Pow(10, i));
            l1Num += (BigInteger)plusPamarm;
            l1 = l1.next;
            ++i;
        }

        while (l2 != null)
        {
            BigInteger plusPamarm = (BigInteger)(l2.val * BigInteger.Pow(10, j));
            l2Num += (BigInteger)plusPamarm;
            l2 = l2.next;
            ++j;
        }
        BigInteger sumTotal = l1Num + l2Num;
        return ProcessNumToList(sumTotal);
    }


    public ListNode ProcessNumToList(BigInteger ret)
    {
        if (ret == 0) return new ListNode();
        var num = (BigInteger)ret;
        ListNode head = null;
        ListNode current = null;
        while (num != 0)
        {
            var mod = num % 10;
            ListNode newItem = new ListNode((int)mod);

            if (head == null)
            {
                head = newItem;
                current = head;
            }
            else
            {
                current.next = newItem;
                current = newItem;
            }
            num /= 10;
        }

        return head;
    }


    public ListNode ReverseListNode(ListNode head)
    {
        if (head.next == null)
        {
            return head;
        }


        ListNode temp = ReverseListNode(head.next);

        head.next.next = head;
        head.next = null;
        return temp;
    }


    // public List<BigInteger > ProcessNumToListNode(BigInteger  num)
    // {
    //     var stirngNum = num.ToString();
    //     List<BigInteger > head = new List<BigInteger >();
    //     head = num.ToString()
    //         .Select(c => c - '0')  // 将字符转为数字
    //         .ToList();
    //     return head;
    // }
    //
    // public List<BigInteger > AddTwoNumbers(List<BigInteger > l1, List<BigInteger > l2) {
    //     var l1Num = 0;
    //     var l2Num = 0;
    //     for (BigInteger  i = 0 ;i < l1.Count(); i++)
    //     {
    //             var plusPamarm = l1[l1.Count- 1 -i] * Math.Pow(10,i);
    //             l1Num +=  (BigInteger )plusPamarm;
    //     }
    //     for (BigInteger  j = 0 ;j < l2.Count(); j++)
    //     {
    //         var plusPamarm =  l2[l2.Count- 1 -j]* Math.Pow(10,j);
    //         l2Num += (BigInteger )plusPamarm;
    //     }
    //     BigInteger  sumTotal = l1Num +  l2Num;
    //     return ProcessNumToListNode(sumTotal);
    //     
    // }
}