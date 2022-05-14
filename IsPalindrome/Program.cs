﻿using System;
using System.Text.RegularExpressions;

namespace IsPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string str)
        {
           
            string s =Regex.Replace(str, @"[^A-Za-z0-9]+","").ToLower();
            int i = 0;
            int len = s.Length - 1;
            while (i < len)
            {
                if (s[i] != s[len])
                {
                    return false;
                }

                i++;
                len--;
            }
            return true;


            /*
             Without Regex:
             if(s == "" || s.Length < 1)
            return true;
        
            int l = 0, r = s.Length-1; // set 2 pointers at two ends of the string
        
             while(l<r)
            {
                while(l<r && !char.IsLetterOrDigit(s[l])) // if a char is not a letter or digit, skip it
                l++;
                while(l<r && !char.IsLetterOrDigit(s[r])) // if a char is not a letter or digit, skip it
                r--;
                if(l<r && char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
                l++;        // must increment pointer on left side
                r--;        // must decrement pointer on right side
            }
            return true;

            */

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
