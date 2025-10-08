using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //242. Valid Anagram
        //Runtime O(N)
        //Space O(N)
        public bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (dic.ContainsKey(str1[i]))
                {
                    dic[str1[i]] = dic[str1[i]] + 1;
                }
                else
                {
                    dic.Add(str1[i], 1);
                }
            }
            for (int j = 0; j < str2.Length; j++)
            {
                if (!dic.ContainsKey(str2[j]) || dic[str2[j]] == 0)
                {
                    return false;
                }
                else
                {
                    dic[str2[j]] -= 1;
                }
            }
            return true;
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


        //271 .Encode and Decode Strings
        //Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

        //Please implement encode and decode

        //Example 1:

        //Input: ["neet", "code", "love", "you"]

        //Output:["neet", "code", "love", "you"]
        //Example 2:

        //Input: ["we", "say", ":", "yes"]

        //Output: ["we", "say", ":", "yes"]
        //Constraints:

        //0 <= strs.length< 100
        //0 <= strs[i].length< 200
        //strs[i] contains only UTF-8 characters.

        //public string Encode(IList<string> strs)
        //{

        //}

        //public List<string> Decode(string s)
        //{

        //}
    }
}