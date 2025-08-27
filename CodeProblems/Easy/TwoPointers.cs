using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Easy
{
    public class TwoPointers
    {
        //125. Valid Palindrome
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

        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' ||
                    s[i] >= 'A' && s[i] <= 'Z' ||
                    s[i] >= '0' && s[i] <= '9')
                {

                    newString += s[i];
                }
            }

            int left = 0;
            int right = newString.Length - 1;

            while (left < right)
            {
                if (newString[left] != newString[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }





        //392. Is Subsequence

        //Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

        //A subsequence of a string is a new string that is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).



        //Example 1:

        //Input: s = "abc", t = "ahbgdc"
        //Output: true
        //Example 2:

        //Input: s = "axc", t = "ahbgdc"
        //Output: false


        //Constraints:

        //0 <= s.length <= 100
        //0 <= t.length <= 104
        //s and t consist only of lowercase English letters.


        //Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence.In this scenario, how would you change your code?

        //Runtime = O(n)
        //Space = O(1)
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }
    }
}
