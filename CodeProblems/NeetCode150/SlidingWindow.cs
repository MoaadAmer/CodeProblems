namespace CodeProblems.NeetCode150
{
    public class SlidingWindow
    {
        //121. Best Time to Buy and Sell Stock
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //Example 1:

        //Input: prices = [7, 1, 5, 3, 6, 4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        //Example 2:

        //Input: prices = [7, 6, 4, 3, 1]
        //Output: 0
        //Explanation: In this case, no transactions are done and the max profit = 0.


        //Constraints:

        //1 <= prices.length <= 105
        //0 <= prices[i] <= 104


        //Soultion Complexity
        //Runtime O(N)
        //Space O(1)

        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
            {
                return 0;
            }
            int l = 0;
            int r = 1;
            int max = 0;
            while (r < prices.Length)
            {
                int profit = prices[r] - prices[l];
                if (profit > max)
                {
                    max = profit;
                }
                //i can buy in less
                else if (profit < 0)
                {
                    l = r;
                }
                r++;
            }
            return max;
        }

        //3. Longest Substring Without Repeating Characters
        //Medium

        //Given a string s, find the length of the longest substring without duplicate characters.

        //Example 1:

        //Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.
        //Example 2:

        //Input: s = "bbbbb"
        //Output: 1
        //Explanation: The answer is "b", with the length of 1.
        //Example 3:

        //Input: s = "pwwkew"
        //Output: 3
        //Explanation: The answer is "wke", with the length of 3.
        //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.


        //Constraints:

        //0 <= s.length <= 5 * 104
        //s consists of English letters, digits, symbols and spaces.

        //Solution 1
        //Runtime O(N)
        //Space O(N)

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2)
            {
                return s.Length;
            }
            int l = 0;
            int r = 0;
            int max = 0;
            HashSet<char> chars = new HashSet<char>();
            while (r < s.Length)
            {
                while (chars.Contains(s[r]))
                {
                    chars.Remove(s[l]);
                    l++;
                }
                chars.Add(s[r]);
                if (chars.Count > max)
                {
                    max = chars.Count;
                }
                r++;
            }
            return max;
        }

    }
}
