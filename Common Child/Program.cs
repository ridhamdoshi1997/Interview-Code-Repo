using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Child
{
   
    internal class Program
    {
        public static int commonChild(string s1, string s2)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();
            Dictionary<int,char> dictt = new Dictionary<int, char>();
            int counter = 0;
            for (int i = 0; i < s1.Length; i++)
            {
               
               dict.Add(i, s1[i]);     
               dictt.Add(i, s2[i]);
                         
            }
            
            for(int i=0;i<dict.Count;i++)
            {
                if (dictt.ContainsValue(dict[i]))
                {
                    int key2 = dictt.FirstOrDefault(x => x.Value == s1[i]).Key;
                    if (Math.Abs(i - key2) <= 2)
                    {
                        counter++;
                    }
                }
            }
          
            return counter;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = commonChild(s1, s2);

            Console.WriteLine(result);
        }
    }
}
