using System;
using System.Collections.Generic;

namespace Roman_to_Int
{
    internal class Program
    {
        public static  Dictionary<char, int> Numerals = new Dictionary<char, int>()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };
        public static int RomanToInt(string s)
        {
             
               int ans = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {

              
                if (i > 0 && (s[i] == 'M' && s[i - 1] == 'C')) 
                { 
                    ans += 900; 
                    i =i- 1; 
                    continue; 
                }
                if (i > 0 && (s[i] == 'D' && s[i - 1] == 'C')) 
                { 
                    ans += 400; 
                    i = i-1; 
                    continue; 
                }
                if (i > 0 && (s[i] == 'C' && s[i - 1] == 'X')) 
                { 
                    ans += 90; 
                    i =i- 1; 
                    continue; 
                }
                if (i > 0 && (s[i] == 'L' && s[i - 1] == 'X')) 
                { 
                    ans += 40; 
                    i =i- 1; 
                    continue; 
                }
                if (i > 0 && (s[i] == 'X' && s[i - 1] == 'I')) 
                { 
                    ans += 9; 
                    i =i- 1; 
                    continue; 
                }
                if (i > 0 && (s[i] == 'V' && s[i - 1] == 'I')) 
                { 
                    ans += 4; 
                    i =i- 1; 
                    continue; 
                }
 
                if (Numerals[s[i]] != 0)
                {
                    ans = ans + Numerals[s[i]];
                }
                    
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IVV"));
        }
    }
}
