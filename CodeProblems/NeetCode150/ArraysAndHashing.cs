using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeProblems.NeetCode150
{
    public class ArraysAndHashing
    {
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
                string key = "";
                for (int i = 0; i < lettersCount.Length; i++)
                {
                    key += (char)('a' + i) + lettersCount[i];
                }
                if (count.ContainsKey(key))
                {
                    count[key].Add(str);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(str);
                    count.Add(key, list);
                }
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
    }
}