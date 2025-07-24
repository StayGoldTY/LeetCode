using System.ComponentModel;

namespace LeetCode;

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
 }

public class TWO {
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        l1 = ReverseListNode(l1);
        l2 = ReverseListNode(l2);
        var l1Num = 0;
        var l2Num = 0;
        var newListNode1 = new  ListNode();
        var newListNode2 = new  ListNode();
        while (newListNode1 != null)
        {
            int i = 0;
            var plusPamarm =  l1.val* Math.Pow(10,i);
            l1Num += (int)plusPamarm;
            newListNode1 = l1.next;
            i++;
        }
        while (newListNode2 != null)
        {
            int i = 0;
            var plusPamarm =  l2.val* Math.Pow(10,i);
            l2Num += (int)plusPamarm;
            newListNode2 = l2.next;
            i++;
        }
        int sumTotal = l1Num +  l2Num;
        return ProcessNumToList(sumTotal);

    }

    public ListNode ReverseListNode(ListNode l)
    {
        if(l.next == null) return l;
       
        ListNode temp = ReverseListNode(l.next);
        ListNode ret = new ListNode(l.val);
        ret.next = temp;
        return ret;
    }
    
    public ListNode ProcessNumToList(int num)
    {
        var charNum = num.ToString()
            .Select(c => c - '0');  // 将字符转为数字
        ListNode head = new ListNode();
        foreach (var charItem in charNum)
        {
            head.val = charItem;
            head.next = null;
        }

       
            
        return head;
    }
    
    
    
    public List<int> ProcessNumToListNode(int num)
    {
        var stirngNum = num.ToString();
        List<int> head = new List<int>();
        head = num.ToString()
            .Select(c => c - '0')  // 将字符转为数字
            .ToList();
        return head;
    }
    
    public List<int> AddTwoNumbers(List<int> l1, List<int> l2) {
        var l1Num = 0;
        var l2Num = 0;
        for (int i = 0 ;i < l1.Count(); i++)
        {
                var plusPamarm = l1[l1.Count- 1 -i] * Math.Pow(10,i);
                l1Num +=  (int)plusPamarm;
        }
        for (int j = 0 ;j < l2.Count(); j++)
        {
            var plusPamarm =  l2[l2.Count- 1 -j]* Math.Pow(10,j);
            l2Num += (int)plusPamarm;
        }
        int sumTotal = l1Num +  l2Num;
        return ProcessNumToListNode(sumTotal);
        
    }
    
    
    
    
}