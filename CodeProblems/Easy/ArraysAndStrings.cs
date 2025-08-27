using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeProblems.Easy;

public class ArraysAndStrings
{


    /// <summary>
    ///You are given a string s.
    ///Your task is to remove all digits by doing this operation repeatedly:
    ///Delete the first digit and the closest non-digit character to its left.
    ///Return the resulting string after removing all digits.
    ///Example 1:
    ///Input: s = "abc"
    ///Output: "abc"
    ///Explanation:
    ///There is no digit in the string.
    ///Example 2:
    ///Input: s = "cb34"
    ///Output: ""
    ///Explanation:
    ///First, we apply the operation on s[2], and s becomes "c4".
    ///Then we apply the operation on s[1], and s becomes "".
    ///Constraints:
    ///1 <= s.length <= 100
    ///s consists only of lowercase English letters and digits.
    ///The input is generated such that it is possible to delete all digits.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    public static string ClearDigits(string s)
    {
        char[] chars = s.ToCharArray();

        for (int i = chars.Length - 1; i >= 0; i--)
        {
            if (chars[i] >= '0' && chars[i] <= '9')
            {
                chars[i] = '$';
                for (int j = i - 1; j >= 0; j--)
                {
                    if (chars[j] >= 'a' && chars[j] <= 'z')
                    {
                        chars[j] = '$';
                        break;
                    }
                }
            }
        }
        string result = "";
        foreach (char c in chars)
        {
            if (c != '$')
            {
                result += c;
            }
        }
        return result;
    }



    //// <summary>
    ////        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    ////        You may assume that each input would have exactly one solution, and you may not use the same element twice.

    ////        You can return the answer in any order.




    ////        Example 1:


    ////        Input: nums = [2, 7, 11, 15], target = 9
    ////        Output: [0, 1]
    ////        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    ////Example 2:


    ////        Input: nums = [3, 2, 4], target = 6
    ////        Output: [1, 2]
    ////        Example 3:


    ////        Input: nums = [3, 3], target = 6
    ////        Output: [0, 1]


    ////        Constraints:

    ////2 <= nums.length <= 104
    ////-109 <= nums[i] <= 109
    ////-109 <= target <= 109
    ////Only one valid answer exists.
    //// </summary>
    //// <param name="s"></param>
    //// <returns></returns>

    //public int[] TwoSum(int[] nums, int target)
    //{

    //    //O(N^2)
    //    //int i, j;

    //    //for (i = 0; i < nums.Length; i++)
    //    //{
    //    //    for (j = i + 1; j < nums.Length; j++)
    //    //    {
    //    //        if (nums[i] + nums[j] == target)
    //    //        {
    //    //            return new int[] { i, j };
    //    //        }
    //    //    }
    //    //}
    //    //

    //    //O(N * log(n))
    //    int[] sortedArray = new int[nums.Length];
    //    Array.Copy(nums, sortedArray, nums.Length);
    //    Array.Sort(sortedArray);

    //    int i = 0;
    //    int j = nums.Length - 1;

    //    while (i < j)
    //    {
    //        if (sortedArray[i] + sortedArray[j] == target)
    //        {
    //            break;
    //        }
    //        else if (sortedArray[i] + sortedArray[j] < target)
    //        {
    //            i++;
    //        }
    //        else
    //        {
    //            j--;
    //        }
    //    }

    //    int k = -1;
    //    int l = -1;

    //    for (int m = 0; m < nums.Length; m++)
    //    {
    //        if (nums[m] == sortedArray[i] && k == -1)
    //        {
    //            k = m;
    //        }
    //        else if (nums[m] == sortedArray[j] && l == -1)
    //        {
    //            l = m;
    //        }
    //        if (k != -1 && l != -1)
    //        {
    //            break;
    //        }
    //    }
    //    return [k, l];


    //}

    //// <summary>
    //// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    ////    Symbol Value
    ////I             1
    ////V             5
    ////X             10
    ////L             50
    ////C             100
    ////D             500
    ////M             1000
    ////For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.

    ////Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

    ////I can be placed before V (5) and X(10) to make 4 and 9. 
    ////X can be placed before L(50) and C(100) to make 40 and 90. 
    ////C can be placed before D(500) and M(1000) to make 400 and 900.
    ////Given a roman numeral, convert it to an integer.



    ////Example 1:

    ////Input: s = "III"
    ////Output: 3
    ////Explanation: III = 3.
    ////Example 2:

    ////Input: s = "LVIII"
    ////Output: 58
    ////Explanation: L = 50, V= 5, III = 3.
    ////Example 3:

    ////Input: s = "MCMXCIV"
    ////Output: 1994
    ////Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


    ////Constraints:

    ////1 <= s.length <= 15
    ////s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    ////It is guaranteed that s is a valid roman numeral in the range[1, 3999].
    //// </summary>
    //// <param name="s"></param>
    //// <returns></returns>
    public static int RomanToInt(string s)
    {
        var romanToInt = new Dictionary<char, int>();
        romanToInt['I'] = 1;
        romanToInt['V'] = 5;
        romanToInt['X'] = 10;
        romanToInt['L'] = 50;
        romanToInt['C'] = 100;
        romanToInt['D'] = 500;
        romanToInt['M'] = 1000;

        int result = 0;
        int i = 0;
        for (; i < s.Length - 1; i++)
        {
            if (romanToInt[s[i]] < romanToInt[s[i + 1]])
            {
                result += romanToInt[s[i + 1]] - romanToInt[s[i]];
                i++;
            }
            else
            {
                result += romanToInt[s[i]];
            }
        }
        if (i < s.Length)
        {
            result += romanToInt[s[i]];
        }
        return result;
    }


    public int[] twoSum(int[] nums, int target)
    {
        //brute force soultion - O(n^2)	
        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //        {
        //            int[] result = new int[2];
        //            result[0] = i;
        //            result[1] = j;
        //            return result;
        //        }
        //    }
        //}
        //return null;

        //O(N)
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int lookingFor = target - nums[i];
            if (numbers.ContainsKey(lookingFor))
            {
                result[0] = numbers.GetValueOrDefault(lookingFor);
                result[1] = i;
                return result;
            }
            else
            {
                numbers[nums[i]] = i;
            }
        }
        return result;


        ////O(N Log(n))
        //int[] result = new int[2] { -1, -1 };
        //int num1, num2;
        //int[] numsCopy = new int[nums.Length];

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    numsCopy[i] = nums[i];

        //}

        //Array.Sort(nums);
        //int left = 0;
        //int right = nums.Length - 1;
        //while (left < right)
        //{
        //    if (nums[left] + nums[right] < target)
        //    {
        //        left++;
        //    }
        //    else if (nums[left] + nums[right] > target)
        //    {
        //        right--;
        //    }
        //    else
        //    {
        //        break;
        //    }

        //}

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (numsCopy[i] == nums[left] && result[0] == -1)
        //    {
        //        result[0] = i;
        //    }
        //    else if (numsCopy[i] == nums[right] && result[1] == -1)
        //    {
        //        result[1] = i;
        //    }
        //    if (result[0] != -1 && result[1] != -1)
        //    {
        //        break;
        //    }

        //}
        //return result;
    }

    /// <summary>
    /// 125. Valid Palindrome
    //    Easy
    //    Topics
    //Companies
    //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.

    //Given a string s, return true if it is a palindrome, or false otherwise.



    //Example 1:

    //Input: s = "A man, a plan, a canal: Panama"
    //Output: true
    //Explanation: "amanaplanacanalpanama" is a palindrome.
    //Example 2:

    //Input: s = "race a car"
    //Output: false
    //Explanation: "raceacar" is not a palindrome.
    //Example 3:

    //Input: s = " "
    //Output: true
    //Explanation: s is an empty string "" after removing non-alphanumeric characters.
    //Since an empty string reads the same forward and backward, it is a palindrome.



    //Constraints:

    //1 <= s.length <= 2 * 105
    //s consists only of printable ASCII characters.
    /// </summary>


    public static bool IsPalindrome(string s)
    {

        s = s.ToLower();
        string temp = "";
        int i = 0;

        while (i < s.Length)
        {
            if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= '0' && s[i] <= '9')
            {
                temp += s[i];
            }
            i++;
        }
        int left = 0;
        int right = temp.Length - 1;

        while (left < right)
        {
            if (temp[left] != temp[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return true;
    }


    public static string LongestCommonPrefix(string[] strs)
    {

        string shortest = GetShortestString(strs);
        int globalMax = shortest.Length;
        int currentMax = 0;

        foreach (string s in strs)
        {
            for (int i = 0; i < shortest.Length; i++)
            {
                if (s[i] == shortest[i])
                {
                    currentMax++;
                }
                else
                {
                    break;
                }
            }
            if (currentMax < globalMax)
            {
                globalMax = currentMax;
            }
            currentMax = 0;
        }


        return shortest.Substring(0, globalMax);
    }


    private static string GetShortestString(string[] strs)
    {

        string shortest = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < shortest.Length)
            {
                shortest = strs[i];
            }
        }

        return shortest;


    }

    /// <summary>
    /// 20. Valid Parentheses
    //    Solved
    //    Easy
    //Topics
    //Companies
    //Hint
    //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    //An input string is valid if:

    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.
    //Every close bracket has a corresponding open bracket of the same type.


    //Example 1:

    //Input: s = "()"

    //Output: true

    //Example 2:

    //Input: s = "()[]{}"

    //Output: true

    //Example 3:

    //Input: s = "(]"

    //Output: false

    //Example 4:

    //Input: s = "([])"

    //Output: true


    //Constraints:

    //1 <= s.length <= 104
    //s consists of parentheses only '()[]{}'.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    public bool IsValid(string s)
    {
        var stack = new Stack<int>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (stack.Count() == 0 ||
                     c == ')' && stack.Peek() != '(' ||
                      c == '}' && stack.Peek() != '{' ||
                      c == ']' && stack.Peek() != '[')
            {
                return false;
            }
            else
            {
                stack.Pop();
            }

        }
        return stack.Count == 0;

    }











    //-----------------------------------------------------------
    //21. Merge Two Sorted Lists
    //    You are given the heads of two sorted linked lists list1 and list2.
    //    Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.

    //Return the head of the merged linked list.




    //Example 1:


    //Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
    //Output: [1, 1, 2, 3, 4, 4]
    //    Example 2:

    //Input: list1 = [], list2 = []
    //Output: []
    //    Example 3:

    //Input: list1 = [], list2 = [0]
    //Output: [0]


    //Constraints:

    //The number of nodes in both lists is in the range [0, 50].
    //-100 <= Node.val <= 100
    //Both list1 and list2 are sorted in non-decreasing order.






    //Definition for singly-linked list.
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


    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //Solution 1 - creates new list
        ListNode head = new ListNode(-1, null);
        ListNode current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = new ListNode(list1.val, null);
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val, null); ;
                list2 = list2.next;
            }
            current = current.next;
        }
        if (list1 != null || list2 != null)
        {
            while (list1 != null)
            {
                current.next = new ListNode(list1.val, null); ;
                list1 = list1.next;
                current = current.next;
            }
            while (list2 != null)
            {
                current.next = new ListNode(list2.val, null); ;
                list2 = list2.next;
                current = current.next;

            }
        }
        return head.next;
    }



    //Solution 2 - Change the current list pointer
    //ListNode head = new ListNode(-1, null);
    //ListNode current = head;

    //while (list1 != null && list2 != null)
    //{
    //    if (list1.val < list2.val)
    //    {
    //        current.next = list1;
    //        list1 = list1.next;
    //    }
    //    else
    //    {
    //        current.next = list2;
    //        list2 = list2.next;
    //    }
    //    current = current.next;
    //}
    //if (list1 == null)
    //{
    //    current.next = list2;
    //}
    //else
    //{
    //    current.next = list1;
    //}
    //return head.next;

    //28. Find the Index of the First Occurrence in a String
    //Given two strings needle and haystack, return the index of the first occurrence of
    //needle in haystack, or -1 if needle is not part of haystack.



    //Example 1:

    //Input: haystack = "sadbutsad", needle = "sad"
    //Output: 0
    //Explanation: "sad" occurs at index 0 and 6.
    //The first occurrence is at index 0, so we return 0.
    //Example 2:

    //Input: haystack = "leetcode", needle = "leeto"
    //Output: -1
    //Explanation: "leeto" did not occur in "leetcode", so we return -1.



    //Constraints:

    //1 <= haystack.length, needle.length <= 104
    //haystack and needle consist of only lowercase English characters.

    public int StrStr(string haystack, string needle)
    {
        int j = 0;
        while (j < haystack.Length)
        {
            if (needle[0] == haystack[j])
            {
                int k = 0;
                int i = j;

                while (k < needle.Length &&
                       j < haystack.Length &&
                       needle[k] == haystack[j])
                {
                    k++;
                    j++;
                }
                if (k == needle.Length)
                {
                    return i;
                }
                else
                {
                    j = i;
                }
            }
            j++;
        }

        return -1;

    }


    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return [dic.GetValueOrDefault(target - nums[i]), i];
            }
            else if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return [];
    }

}