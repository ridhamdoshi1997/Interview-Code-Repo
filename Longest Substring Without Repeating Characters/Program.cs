using System;
using System.Collections.Generic;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int result = 0;
            //int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);

                }
                else
                {
                    result = Math.Max(map.Count, result);
                    i = map[s[i]];
                    map.Clear();

                }
            }
            /*return result;


            if (s.Length == 0 || s.Length < 2 || String.IsNullOrEmpty(s))
                return s.Length;
            var dict = new Dictionary<char, int>();
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    result = Math.Max(dict.Count, result);
                    i = dict[s[i]];
                    dict.Clear();
                }
                else
                {
                    dict.Add(s[i], i);
                }
            }*/
            return Math.Max(map.Count, result);



        }
        static void Main(string[] args)
        {
            string s = "dvdf";
            Console.WriteLine(LengthOfLongestSubstring(s).ToString());
        }
    }
}
