

using CodeProblems.Easy;
using CodeProblems.Fundamentals.Recursion;
using CodeProblems.Fundamentals.Sorting;
using CodeProblems.NeetCode150;
using Xunit;

//Console.WriteLine(EasyProblems.ClearDigits("cb34"));


//var s = "MCMXCIV";

//Console.WriteLine(EasyProblems.RomanToInt(s));


//Console.WriteLine(EasyProblems.IsPalindrome("A man, a plan, a canal: Panama"));


//string[] strs = ["cir", "car"];
//Console.WriteLine(EasyProblems.LongestCommonPrefix(strs));


//var l1 = new ArraysAndStrings.ListNode(1);
//l1.next = new ArraysAndStrings.ListNode(2);
//l1.next.next = new ArraysAndStrings.ListNode(3);

//var l2 = new ArraysAndStrings.ListNode(1);
//l2.next = new ArraysAndStrings.ListNode(3);
//l2.next.next = new ArraysAndStrings.ListNode(4);
//l2.next.next.next = new ArraysAndStrings.ListNode(5);

//var l3 = ArraysAndStrings.MergeTwoLists(l1, l2);

//Console.WriteLine();


//var map = new HashMap();

//Console.WriteLine(map.CanConstruct("aa", "aab"));


//ArraysAndHashing arraysAndHashing = new ArraysAndHashing();
////arraysAndHashing.GroupAnagrams2(["bdddddddddd", "bbbbbbbbbbc"]);

//arraysAndHashing.TopKFrequent([1, 2, 1, 2, 1, 2, 3, 1, 3, 2], 2);

//Sorting sorting = new Sorting();
//int[] nums = [-5, 3, 2,1,-3,-3,7,2,2];
//sorting.BubbleSort(nums);
//Console.WriteLine("BubbleSort:");
//foreach(int num in nums)
//{
//    Console.WriteLine(num);
//}

//nums = [-5, 3, 2, 1, -3, -3, 7, 2, 2];
//sorting.InsertionSort(nums);
//Console.WriteLine("InsertionSort:");
//foreach (int num in nums)
//{
//    Console.WriteLine(num);
//}


//nums = [-5, 3, 2, 1, -3, -3, 7, 2, 2];
//sorting.SelectionSort(nums);
//Console.WriteLine("SelectionSort:");
//foreach (int num in nums)
//{
//    Console.WriteLine(num);
//}

//Recursion recursion = new Recursion();
//Console.WriteLine("Factorial(0):");
//Assert.Equal(1, recursion.Factorial(0));

//Console.WriteLine("Factorial(1):");
//Assert.Equal(1, recursion.Factorial(1));

//Console.WriteLine("Factorial(2):");
//Assert.Equal(2, recursion.Factorial(2));


//Console.WriteLine("Factorial(3):");
//Assert.Equal(6, recursion.Factorial(3));


//Console.WriteLine("Factorial(4):");
//Assert.Equal(24, recursion.Factorial(4));



Recursion recursion = new Recursion();
Console.WriteLine("Fibonacci(0):");
Assert.Equal(0, recursion.Fibonacci(0));

Console.WriteLine("Fibonacci(1):");
Assert.Equal(1, recursion.Fibonacci(1));

Console.WriteLine("Fibonacci(2):");
Assert.Equal(1, recursion.Fibonacci(2));


Console.WriteLine("Fibonacci(3):");
Assert.Equal(2, recursion.Fibonacci(3));


Console.WriteLine("Fibonacci(4):");
Assert.Equal(3, recursion.Fibonacci(4));

Console.WriteLine("Fibonacci(5):");
Assert.Equal(5, recursion.Fibonacci(5));