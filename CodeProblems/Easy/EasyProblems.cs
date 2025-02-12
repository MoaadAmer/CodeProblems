namespace CodeProblems.Easy;

public class EasyProblems
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

    public int[] TwoSum(int[] nums, int target)
    {

        //O(N^2)
        //int i, j;

        //for (i = 0; i < nums.Length; i++)
        //{
        //    for (j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //        {
        //            return new int[] { i, j };
        //        }
        //    }
        //}
        //

        //O(N * log(n))
        int[] sortedArray = new int[nums.Length];
        Array.Copy(nums, sortedArray, nums.Length);
        Array.Sort(sortedArray);

        int i = 0;
        int j = nums.Length - 1;

        while (i < j)
        {
            if (sortedArray[i] + sortedArray[j] == target)
            {
                break;
            }
            else if (sortedArray[i] + sortedArray[j] < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        int k = -1;
        int l = -1;

        for (int m = 0; m < nums.Length; m++)
        {
            if (nums[m] == sortedArray[i] && k == -1)
            {
                k = m;
            }
            else if (nums[m] == sortedArray[j] && l == -1)
            {
                l = m;
            }
            if (k != -1 && l != -1)
            {
                break;
            }
        }
        return [k, l];


    }
}