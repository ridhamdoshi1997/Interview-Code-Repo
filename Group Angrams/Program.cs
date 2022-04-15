using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_Angrams
{
    internal class Program
    {
        public static List<List<string>> GroupAnagrams(List<string> strs)
        {
            Dictionary<string, List<string>> angramID = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                String newString = new String(charArray);
                if(!angramID.ContainsKey(newString))
                {
                    angramID.Add(newString, new List<string>());
                }
               angramID[newString].Add(str);

            }

            return new List<List<String>>(angramID.Values);
        }

        public static List<string> SplitWords(string s)
        {
            return string.IsNullOrEmpty(s) ? new List<string>() : s.Trim().Split(' ').ToList();
        }
        static void Main(string[] args)
        {
            List<string> strs = SplitWords(Console.ReadLine());
            List<List<string>> res = GroupAnagrams(strs);
            foreach (List<string> row in res)
            {
                row.Sort();
            }
            res.Sort((a, b) => { a[0].CompareTo(b[0]); return 1; });
            foreach (List<string> row in res)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}
