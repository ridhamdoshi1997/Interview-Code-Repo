using System;
using System.Collections.Generic;

namespace Isomorphic_String
{
    internal class Program
    {
        public static bool IsIsomorphic(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            Dictionary<char, char> dict = new Dictionary<char, char>();
            HashSet<char> used = new HashSet<char>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (!dict.ContainsKey(str1[i]))
                {
                    if (used.Contains(str2[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dict.Add(str1[i], str2[i]);
                        used.Add(str2[i]);
                    }

                }
                else
                {

                    if (dict[str1[i]] != str2[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool res = IsIsomorphic(str1, str2);
            Console.WriteLine(res);
        }
    }
}
