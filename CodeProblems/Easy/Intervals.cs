using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Easy
{
    //228. Summary Ranges
    //You are given a sorted unique integer array nums.

    //A range[a, b] is the set of all integers from a to b(inclusive).

    //Return the smallest sorted list of ranges that cover all the numbers in the array exactly.That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

    //Each range[a, b] in the list should be output as:

    //"a->b" if a != b
    //"a" if a == b


    //Example 1:

    //Input: nums = [0, 1, 2, 4, 5, 7]
    //Output: ["0->2", "4->5", "7"]
    //Explanation: The ranges are:
    //[0, 2] --> "0->2"
    //[4, 5] --> "4->5"
    //[7, 7] --> "7"
    //Example 2:

    //Input: nums = [0, 2, 3, 4, 6, 8, 9]
    //Output: ["0", "2->4", "6", "8->9"]
    //Explanation: The ranges are:
    //[0, 0] --> "0"
    //[2, 4] --> "2->4"
    //[6, 6] --> "6"
    //[8, 9] --> "8->9"

    public class Intervals
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            int a = 0, b = 0, left = 0, right = 0;

            for (left = right; left < nums.Length;)
            {
                a = nums[left];

                while (right < nums.Length - 1 && nums[right + 1] - nums[right] == 1)
                {
                    right++;
                }
                b = nums[right];
                if (a == b)
                {
                    result.Add($"{a}");
                }
                else
                {
                    result.Add($"{a}->{b}");
                }
                right = right + 1;
                left = right;
            }
            return result;
        }
    }
}
