using System;
using System.Collections.Generic;

namespace Backspace_String_Compare
{
    internal class Program
    {
        public static bool BackspaceCompare(string s, string t)
        {
            Stack<char> sst = new Stack<char>();
            Stack<char> tst = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '#')
                {
                    sst.Push(s[i]);
                }
                else
                {
                    if (sst.Count > 0)
                    {
                        sst.Pop();
                    }
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != '#')
                {
                    tst.Push(t[i]);
                }
                else
                {

                    if (tst.Count > 0)
                    {
                        tst.Pop();
                    }
                }
            }
            if (sst.Count == 0 && tst.Count == 0)
            {
                return true;
            }
           string news= String.Join("", sst);
            string newt = String.Join("", tst);
            return (news == newt) ? true : false;

        }
        static void Main(string[] args)
        {
            string s = "bxj##tw";
            string t = "bxj###tw";
            Console.WriteLine(BackspaceCompare(s,t));
        }
    }
}
