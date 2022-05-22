using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluate_Reverse_Polish_Notation
{

    internal class Program
    {
        public static int EvalRPN(string[] tokens)
        {
            
            Stack<int> st = new Stack<int>();
            foreach(string s in tokens)
            {
                    if (s=="+")
                    {
                        int n2 = st.Pop();
                        int n1 = st.Pop();
                        int result = n1 + n2;
                        st.Push(result);
                    }
                    else if (s== "-")
                    {
                        int n2 = st.Pop();
                        int n1 = st.Pop();
                        int result = n1 - n2;
                        st.Push(result);
                    }
                    else if (s == "*")
                    {
                        int n2 = st.Pop();
                        int n1 = st.Pop();
                        int result = n1 * n2;
                        st.Push(result);
                    }
                    else if (s == "/")
                    {
                        int n2 = st.Pop();
                        int n1 = st.Pop();
                        int result = n1 / n2;
                        st.Push(result);
                    }
                    else
                    {
                         st.Push(int.Parse(s));
                    }
                
            }
            return st.Peek();
        }
        static void Main(string[] args)
        {
            string[] s = { "4", "13", "5", "/", "+" };
            Console.WriteLine(EvalRPN(s));
        }
    }
}
