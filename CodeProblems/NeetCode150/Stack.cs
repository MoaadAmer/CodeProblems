namespace CodeProblems.NeetCode150
{
    public class Stack
    {
        //20. Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //Easy
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

        //Example 5:

        //Input: s = "([)]"

        //Output: false




        //Constraints:

        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.

        //Solution 
        //Runtime O(N)
        //Space O(N)

        public bool IsValid(string s)
        {
            char[] stack = new char[s.Length];
            int sIndex = -1;
            foreach (char c in s)
            {
                if (c == ')' || c == ']' || c == '}')
                {
                    if (sIndex == -1 ||
                        c == ')' && stack[sIndex] != '(' ||
                        c == ']' && stack[sIndex] != '[' ||
                        c == '}' && stack[sIndex] != '{'
                        )
                    {
                        return false;
                    }
                    else
                    {
                        sIndex--;
                    }
                }
                else
                {
                    stack[++sIndex] = c;
                }
            }
            return sIndex == -1;
        }
    }
}
