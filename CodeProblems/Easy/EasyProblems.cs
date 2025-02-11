using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeProblems.Easy
{
    public class EasyProblems
    {

        //You are given a string s.

        //Your task is to remove all digits by doing this operation repeatedly:

        //Delete the first digit and the closest non-digit character to its left.
        //Return the resulting string after removing all digits.


        //Example 1:

        //Input: s = "abc"

        //Output: "abc"

        //Explanation:

        //There is no digit in the string.

        //Example 2:

        //Input: s = "cb34"

        //Output: ""

        //Explanation:

        //First, we apply the operation on s[2], and s becomes "c4".

        //Then we apply the operation on s[1], and s becomes "".


        //Constraints:

        //1 <= s.length <= 100
        //s consists only of lowercase English letters and digits.
        //The input is generated such that it is possible to delete all digits.

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
    }
}
