using System.Diagnostics.Metrics;

namespace CodeProblems.NeetCode150
{
    public class TwoPointers
    {
        //125. Valid Palindrome
        //Easy
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

        //Soultion 1
        //Runtime = O(N)
        //Space = O(N)

        //public bool IsPalindrome(string s)
        //{
        //    s = s.Trim();
        //    s = s.ToLower();
        //    string newString = "";
        //    foreach (char c in s)
        //    {
        //        if (c >= 'a' && c <= 'z' ||
        //            c >= '0' && c <= '9')
        //        {
        //            newString += c;
        //        }
        //    }

        //    int l = 0;
        //    int r = newString.Length - 1;
        //    while (l < r)
        //    {
        //        if (newString[l] != newString[r])
        //        {
        //            return false;
        //        }
        //        l++;
        //        r--;
        //    }
        //    return true;
        //}



        //Soultion 1
        //Runtime = O(N)
        //Space = O(1)
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                while (l < r && !(IsAlphaNumeric(s[l])))
                {
                    l++;
                }
                while (l < r && !(IsAlphaNumeric(s[r])))
                {
                    r--;
                }
                if (ToLower(s[l]) != ToLower(s[r]))
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }

        private char ToLower(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                return (char)(c + 32);
            }
            return c;
        }

        public bool IsAlphaNumeric(char c)
        {
            return
                    c >= 'A' && c <= 'Z' ||
                    c >= 'a' && c <= 'z' ||
                    c >= '0' && c <= '9'
                    ;
        }
    }
}
