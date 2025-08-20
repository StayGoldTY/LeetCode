// See https://aka.ms/new-console-template for more information

using System;
using LeetCode;
using LeetCode.Kata;

Console.WriteLine("Hello, World!");
int[] arr = [11,13,17,23,29,31,7,5,2,3];
var k = 3;
var threshold = 5;
var ret = Q1343.NumOfSubarrays(arr, k, threshold);
// int[] nums = [1, 12, -5, -6, 50, 3];
// var k = 4;
// int[] nums = [-1];
//  var k = 1;
// var ret = Q643.FindMaxAverage(nums,k);
// var s = "abciiidef";
// var k = 3;
// var ret = Q1456.MaxVowels(s,k);

//int[] nums = [0,1,2,3,4,5,6,7,8,9,10,5,2];
//int[] nums = [3,4,5,1];
//int[] nums = [0, 1, 0];
//var ret = Q852.PeakIndexInMountainArray(nums);
// string[] words = ["hey","aeo","mu","ooo","artro"];
// var left = 1; 
// var right = 4;
// var ret = Q2586.VowelStrings(words, left, right);
//var ret = Q1422.MaxScore("00111");
//int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
//int[][] matrix = [[1,2,3],[4,5,6]];
//var ret = Q867.Transpose(matrix);
//int[] nums = [1,2,3,4,4,3,2,1];
//var ret = Q1470.Shuffle(nums,4);
//var ret = Q263.IsUgly(2147483647);
//var ret = Q263.IsUgly(3);
//var ret = Q231.IsPowerOfTwo(536870913);
//var ret = Q1281.SubtractProductAndSum(4421);
//var ret = Q258.AddDigits(111111111);
Console.WriteLine(ret);

// var ret = Q709.ToLowerCase("Hello");
// Console.WriteLine(ret);

// Q1534 q1534 = new Q1534();
// int[] arr = [75,230,548,973,150,558,267,197,700,610,267,111,367,458,15,468,832,526,785,181,534,695,571,320,670,210,911,520,612,257,614,899,377,174,439,267,603,398,838,286,103,693,18,193,27,5,475,284,872,548,213,400,565,132,191,251,205,315,821,265,934,757,966,700,242,593,105,49,964,947,22,467,539,264,22,579,761,977,848,197,442,565,935,848,797,473,158,501,52,132,108,830,852,632,433,549,647,95,607,777] ;
// var a = 80;
// var b = 232;
// var c = 277;

//var retArr = FreqArr.FreqArrKata(arr);

//int[] arr1 = [1, 2, 3, 4, 5, 6,7];
//var retNew = PreSum.RangeSum(arr,3,4);
//Console.WriteLine(retNew);
//var ret = q1534.CountGoodTriplets(arr, a, b, c);
//Console.WriteLine(ret);
// int[] nums = [1,1,1,1];
// Q1512 q = new  Q1512();
// q.test1();
// var ret = Q1512.NumIdenticalPairs(nums);
// Console.WriteLine(ret);

// XorOperation(4, 3);
// int XorOperation(int n, int start) {
//     if(n == 1) return start;
//     var ret = start;
//     for(int i = 1;i < n; i++){
//         var currentVlaue = start + 2 * i;
//         ret = ret ^ currentVlaue;
//     }
//     return ret;
// }
//     string number1 = "664";
//     ListNode list11 = CreateListNodeFromString(number1);
//     string number2 = "664";
//     ListNode list12 = CreateListNodeFromString(number2);
//     Q2 two = new Q2();
//     var a= two.AddTwoNumbers(list11,list12);
//
//
//
// // 将字符串中的每一位转为 ListNode
// static ListNode CreateListNodeFromString(string numStr) {
//     if (string.IsNullOrEmpty(numStr)) return null;
//
//     ListNode dummy = new ListNode(0);
//     ListNode current = dummy;
//
//     foreach (char ch in numStr) {
//         int digit = ch - '0';
//         current.next = new ListNode(digit);
//         current = current.next;
//     }
//
//     return dummy.next;
// }



