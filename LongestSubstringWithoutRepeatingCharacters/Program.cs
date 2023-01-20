using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        //Given a string s, find the length of the longest substring without repeating characters.
        static void Main(string[] args)
        {
            Console.WriteLine($"Expected: 3, Output: {LengthOfLongestSubstring("abcabcbb")}");
            Console.WriteLine($"Expected: 1, Output: {LengthOfLongestSubstring("bbbbb")}");
            Console.WriteLine($"Expected: 3, Output: {LengthOfLongestSubstring("pwwkew")}");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            List<int> substringLength = new List<int>();
            List<char> substringChars = new List<char>();
            int counter = 1;
            if (s.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int i2 = i + 1; i2 < s.Length; i2++)
                {
                    if (substringChars.Contains(s[i]) || substringChars.Contains(s[i2]) || s[i] == s[i2])
                    {
                        substringChars.Clear();
                        substringLength.Add(counter);
                        counter = 1;
                        break;
                    }
                    else
                    {
                        substringChars.Add(s[i2]);
                        counter++;
                    }
                }

            }

            if (substringChars.Count != 0)
            {
                substringLength.Add(2);
            }

            if (substringLength.Count == 0)
            {
                return substringChars.Count + 1;
            }
            else
            {
                return substringLength.Max();
            }
        }
    }
}
