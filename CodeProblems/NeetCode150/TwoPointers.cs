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

        private bool IsAlphaNumeric(char c)
        {
            return
                    c >= 'A' && c <= 'Z' ||
                    c >= 'a' && c <= 'z' ||
                    c >= '0' && c <= '9'
                    ;
        }


        //167. Two Sum II - Input Array Is Sorted
        //Medium
        //Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1<index2 <= numbers.length.

        //Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.

        //The tests are generated such that there is exactly one solution.You may not use the same element twice.

        //Your solution must use only constant extra space.




        //Example 1:

        //Input: numbers = [2, 7, 11, 15], target = 9
        //Output: [1, 2]
        //Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2.We return [1, 2].
        //Example 2:

        //Input: numbers = [2, 3, 4], target = 6
        //Output: [1, 3]
        //Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3.We return [1, 3].
        //Example 3:

        //Input: numbers = [-1, 0], target = -1
        //Output: [1, 2]
        //Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2.We return [1, 2].



        //Constraints:

        //2 <= numbers.length <= 3 * 104
        //-1000 <= numbers[i] <= 1000
        //numbers is sorted in non-decreasing order.
        //-1000 <= target <= 1000
        //The tests are generated such that there is exactly one solution.

        //Solution Complexity
        //Runtime O(N)
        //Space O(1)

        public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0;
            int r = numbers.Length - 1;
            while (l < r)
            {
                int currentResult = numbers[l] + numbers[r];
                if (currentResult < target)
                {
                    l++;
                }
                else if (currentResult > target)
                {
                    r--;
                }
                else
                {
                    return new int[2] { l + 1, r + 1 };
                }
            }
            return new int[] { };
        }
    }
}
