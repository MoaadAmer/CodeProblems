using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeProblems.Easy
{
    public class HashMap
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> lettersInMagazine = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (lettersInMagazine.ContainsKey(magazine[i]))
                {
                    lettersInMagazine[magazine[i]] += 1;
                }
                else
                {
                    lettersInMagazine[magazine[i]] = 1;
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (lettersInMagazine.ContainsKey(ransomNote[i]) && lettersInMagazine[ransomNote[i]] != 0)
                {
                    lettersInMagazine[ransomNote[i]] -= 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        //205. Isomorphic Strings

        //Given two strings s and t, determine if they are isomorphic.

        //Two strings s and t are isomorphic if the characters in s can be replaced to get t.

        //All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character, but a character may map to itself.



        //Example 1:

        //Input: s = "egg", t = "add"

        //Output: true

        //Explanation:

        //The strings s and t can be made identical by:

        //Mapping 'e' to 'a'.
        //Mapping 'g' to 'd'.
        //Example 2:

        //Input: s = "foo", t = "bar"

        //Output: false

        //Explanation:

        //The strings s and t can not be made identical as 'o' needs to be mapped to both 'a' and 'r'.

        //Example 3:

        //Input: s = "paper", t = "title"

        //Output: true



        //Constraints:

        //1 <= s.length <= 5 * 104
        //t.length == s.length
        //s and t consist of any valid ascii character.

        //Runtime = O(s)
        //Space= O(s+t)
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, char> ST = new Dictionary<char, char>();
            Dictionary<char, char> TS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (ST.ContainsKey(s[i]) && ST[s[i]] != t[i] ||
                    TS.ContainsKey(t[i]) && TS[t[i]] != s[i])
                {
                    return false;
                }
                else
                {
                    ST[s[i]] = t[i];
                    TS[t[i]] = s[i];
                }
            }
            return true;
        }

        //290. Word Pattern

        //Given a pattern and a string s, find if s follows the same pattern.

        //Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.Specifically:

        //Each letter in pattern maps to exactly one unique word in s.
        //Each unique word in s maps to exactly one letter in pattern.
        //No two letters map to the same word, and no two words map to the same letter.

        //Example 1:

        //Input: pattern = "abba", s = "dog cat cat dog"

        //Output: true

        //Explanation:

        //The bijection can be established as:

        //'a' maps to "dog".
        //'b' maps to "cat".
        //Example 2:

        //Input: pattern = "abba", s = "dog cat cat fish"

        //Output: false

        //Example 3:

        //Input: pattern = "aaaa", s = "dog cat cat dog"

        //Output: false

        //Constraints:

        //1 <= pattern.length <= 300
        //pattern contains only lower-case English letters.
        //1 <= s.length <= 3000
        //s contains only lowercase English letters and spaces ' '.
        //s does not contain any leading or trailing spaces.
        //All the words in s are separated by a single space.

        //Runtime O(n)
        //Space O(n)
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(" ");

            if (pattern.Length != words.Length)
            {
                return false;
            }
            Dictionary<char, string> lettersToWords = new Dictionary<char, string>();
            Dictionary<string, char> wordsToLetters = new Dictionary<string, char>();

            for (int i = 0; i < words.Length; i++)
            {
                if (lettersToWords.ContainsKey(pattern[i]) && lettersToWords[pattern[i]] != words[i] ||
                   wordsToLetters.ContainsKey(words[i]) && wordsToLetters[words[i]] != pattern[i])
                {
                    return false;
                }
                else
                {
                    lettersToWords[pattern[i]] = words[i];
                    wordsToLetters[words[i]] = pattern[i];
                }
            }
            return true;

        }


        public bool IsHappy(int n)
        {
            HashSet<int> numbers = new HashSet<int>();
            while (!numbers.Contains(n))
            {
                int temp = n;
                n = 0;
                while (temp != 0)
                {
                    int digit = temp % 10;
                    n += digit * digit;
                    temp /= 10;
                }
            }
            return n == 1;

        }
    }
}