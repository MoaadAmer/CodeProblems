using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.NeetCode150
{
    internal class ArraysAndHashing
    {

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = [];
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] != "-1")
                {
                    List<string> ang = new List<string>();
                    ang.Add(strs[i]);
                    for (int j = i + 1; j < strs.Length; j++)
                    {
                        if (strs[j] != "-1")
                        {
                            if (IsAnagrams(strs[i], strs[j]))
                            {
                                ang.Add(strs[j]);
                                strs[j] = "-1";
                            }
                        }
                    }

                    strs[i] = "-1";
                    res.Add(ang);
                }
            }
            return res;
        }
        public bool IsAnagrams(string str1, string str2)
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

        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            Dictionary<string, List<string>> dic = [];
            IList<IList<string>> res = [];
            for (int i = 0; i < strs.Length; i++)
            {
                int[] counter = new int[26];
                foreach (char c in strs[i])
                {
                    counter[c - 'a']++;
                }
                string key = "";
                for (int k = 0; k < 26; k++)
                {
                    key += $"{(char)('a' + k)}:{counter[k]}";
                }
                if (dic.ContainsKey(key))
                {

                    dic[key].Add(strs[i]);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(strs[i]);
                    dic.Add(key, list);
                }
            }
            foreach (string k in dic.Keys)
            {
                res.Add(dic[k]);
            }
            return res;
        }


        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            List<int>[] freq = new List<int>[nums.Length + 1];
            int[] result = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                if (counter.ContainsKey(nums[i]))
                {
                    counter[nums[i]] += 1;
                }
                else
                {
                    counter[nums[i]] = 1;
                }
            }
            foreach (int number in counter.Keys)
            {
                int count = counter[number];

                if (freq[count] == null)
                {
                    freq[count] = new List<int>();
                }
                freq[count].Add(number);
            }
            int j = 0;
            for (int i = freq.Length - 1; i > 0; i--)
            {
                if (freq[i] != null)
                {
                    for (int l = 0; l < freq[i].Count; l++)
                    {
                        result[j] = freq[i][l];
                        j++;
                        if (j == k)
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
