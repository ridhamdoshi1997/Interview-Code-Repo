using System;
using System.Collections.Generic;
using System.Linq;

namespace Sherlock_and_the_Valid_String
{
    
    internal class Program
    {
        public static string isValid(string s)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            char[] ch = s.ToCharArray();
            
            for (int i=0;i<ch.Length;i++)
            {
               if(!dict1.ContainsKey(ch[i]))
                {
                    dict1.Add(ch[i], 1);
                }
               else
                {
                    dict1[ch[i]]++;
                }
            }
            int Counter = 0;
            bool IsValid = true;
            KeyValuePair<char, int> First = dict1.First();
            foreach (KeyValuePair<char, int> i in dict1)
            {
                if (First.Value != i.Value)
                {
                    if (Counter >= 1)
                    {
                        IsValid = false;
                        break;
                    }
                    Counter++;
                }
            }
            if (IsValid)
                return IsValid.ToString();
            else
                return IsValid.ToString() ;
           
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);

        }
    }
}
