namespace CodeProblems.NeetCode150
{
    public class ArraysAndHashing
    {

        //217. Contains Duplicate
        //Easy

        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.



        //Example 1:

        //Input: nums = [1, 2, 3, 1]

        //Output: true

        //Explanation:

        //The element 1 occurs at the indices 0 and 3.

        //Example 2:

        //Input: nums = [1, 2, 3, 4]

        //Output: false

        //Explanation:

        //All elements are distinct.

        //Example 3:

        //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]

        //Output: true




        //Constraints:

        //1 <= nums.length <= 105
        //-109 <= nums[i] <= 109

        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return false;
                }
                set.Add(num);
            }
            return true;
        }

        //242. Valid Anagram
        //Easy
        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        //Example 1:

        //Input: s = "anagram", t = "nagaram"

        //Output: true

        //Example 2:

        //Input: s = "rat", t = "car"

        //Output: false



        //Constraints:

        //1 <= s.length, t.length <= 5 * 104
        //s and t consist of lowercase English letters.


        //Runtime O(N)
        //Space O(26)
        public bool IsAnagram(string s, string t)
        {
            int[] counter = new int[26];

            foreach (char c in s)
            {
                counter[c - 'a']++;
            }

            foreach (char c in t)
            {
                counter[c - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (counter[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }


        //1. Two Sum
        //Easy
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.




        //Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        //Example 2:

        //Input: nums = [3, 2, 4], target = 6
        //Output: [1, 2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0, 1]


        //Constraints:

        //2 <= nums.length <= 104
        //-109 <= nums[i] <= 109
        //-109 <= target <= 109
        //Only one valid answer exists.


        //Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

        public int[] TwoSum(int[] nums, int target)
        {
            var prevNumbers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int lookingFor = target - nums[i];
                if (prevNumbers.ContainsKey(lookingFor))
                {
                    return new int[] { prevNumbers[target - nums[i]], i };
                }
                else
                {
                    prevNumbers[nums[i]] = i;
                }
            }
            return new int[2];
        }


        //242. Valid Anagram
        //Runtime O(N)
        //Space O(N)
        //public bool IsAnagram(string str1, string str2)
        //{
        //    if (str1.Length != str2.Length)
        //    {
        //        return false;
        //    }
        //    Dictionary<char, int> dic = new Dictionary<char, int>();
        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        if (dic.ContainsKey(str1[i]))
        //        {
        //            dic[str1[i]] = dic[str1[i]] + 1;
        //        }
        //        else
        //        {
        //            dic.Add(str1[i], 1);
        //        }
        //    }
        //    for (int j = 0; j < str2.Length; j++)
        //    {
        //        if (!dic.ContainsKey(str2[j]) || dic[str2[j]] == 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            dic[str2[j]] -= 1;
        //        }
        //    }
        //    return true;
        //}




        //49. Group Anagrams
        //Runtime O(N*M) where N=Number of strings and M= the average length of the strings
        //Space O(N)
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> count = new();
            foreach (string str in strs)
            {
                int[] lettersCount = new int[26];
                foreach (char c in str)
                {
                    lettersCount[c - 'a']++;
                }
                string key = string.Join(",", lettersCount);
                if (!count.ContainsKey(key))
                {
                    count.Add(key, new List<string>());
                }
                count[key].Add(str);
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (List<string> list in count.Values)
            {
                result.Add(list);
            }
            return result;
        }


        //Runtime O(N)
        //Space O(N)
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            List<int>[] freq = new List<int>[nums.Length + 1];
            int[] result = new int[k];
            foreach (int num in nums)
            {
                if (counter.ContainsKey(num))
                {
                    counter[num] = counter[num] + 1;
                }
                else
                {
                    counter.Add(num, 1);
                }
            }
            foreach (KeyValuePair<int, int> entry in counter)
            {
                if (freq[entry.Value] == null)
                {
                    freq[entry.Value] = new List<int>();
                }
                freq[entry.Value].Add(entry.Key);
            }

            for (int i = freq.Length - 1; i > 0; i--)
            {
                if (freq[i] != null)
                {
                    for (int j = 0; j < freq[i].Count; j++)
                    {
                        result[--k] = freq[i][j];
                        if (k == 0)
                        {
                            return result;
                        }
                    }
                }
            }
            return result;
        }


        //238. Product of Array Except Self
        //Medium
        //Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

        //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        //You must write an algorithm that runs in O(n) time and without using the division operation.



        //Example 1:

        //Input: nums = [1, 2, 3, 4]
        //Output: [24, 12, 8, 6]
        //Example 2:

        //Input: nums = [-1, 1, 0, -3, 3]
        //Output: [0, 0, 9, 0, 0]


        //Constraints:

        //2 <= nums.length <= 105
        //-30 <= nums[i] <= 30
        //The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.



        //Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

        // Runtime O(N)
        //Space O(N)
        //public int[] ProductExceptSelf(int[] nums)
        //{
        //    var prefix = new int[nums.Length + 1];
        //    prefix[0] = 1;
        //    var postfix = new int[nums.Length + 1];
        //    postfix[nums.Length] = 1;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        prefix[i + 1] = nums[i] * prefix[i];
        //    }
        //    for (int i = nums.Length - 1; i >= 0; i--)
        //    {
        //        postfix[i] = nums[i] * postfix[i + 1];
        //    }
        //    var result = new int[nums.Length];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        result[i] = prefix[i] * postfix[i + 1];
        //    }

        //    return result;
        //}


        // Runtime O(N)
        //Space O(1)
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }
            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }
            return result;
        }
    }
}