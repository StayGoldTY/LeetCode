// See https://aka.ms/new-console-template for more information

using System;
using LeetCode;

Console.WriteLine("Hello, World!");
TWO two = new TWO();
ListNode list1 = new ListNode(2);
list1.next = new ListNode(4);
list1.next.next = new ListNode(3);


ListNode list2 = new ListNode(5);
list2.next = new ListNode(6);
list2.next.next = new ListNode(4);
var a= two.AddTwoNumbers(list1,list2);
Console.WriteLine(a);