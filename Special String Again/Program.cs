using System;
using System.Collections.Generic;

namespace Special_String_Again
{
    internal class Program
    {
        static long substrCount(int n, string s)
        {

            Dictionary<char, int> map = new Dictionary<char, int>();
            int result = s.Length;
            //int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);

                }
                else
                {
                    //result = Math.Max(map.Count, result);
                    int j = map[s[i]];
                    map[s[i]]= i;
                    if (i-j<=2)
                    {
                        result++;
                    }
                    

                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string s = "aaaa";
            Console.WriteLine(substrCount(s.Length,s).ToString());
        }
    }
}
