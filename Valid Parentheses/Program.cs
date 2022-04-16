using System;
using System.Collections;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    internal class Program
    {
        public static bool ValidParentheses(string s)
        {
            Stack<char> st = new Stack<char>();
            if (s == null || s == " ")
            {
                return false;
            }
            Dictionary<char, char> result = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count > 0)
                    {
                        var c = st.Pop();
                        if (result[c] != s[i])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }

            }

            if (st.Count > 0)
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool res = ValidParentheses(s);
            Console.WriteLine(res);
        }
    }
}
