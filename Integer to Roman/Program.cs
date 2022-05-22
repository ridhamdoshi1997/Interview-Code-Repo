using System;
using System.Collections.Generic;
using System.Globalization;

namespace Integer_to_Roman
{
    internal class Program
    {
        private static readonly string[] ROMAN_THOUSANDS = { "", "M", "MM", "MMM" };
        private static readonly string[] ROMAN_HUNDREDS = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static readonly string[] ROMAN_TENS = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static readonly string[] ROMAN_ONES = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        public static string IntToRoman(int num)
        {
            /* int n= num;
             string s=null;
             while(n>0)
             {
                 if(n>=1 && n<4)
                 {

                     if(s==null)
                     {
                         s = new string("I");
                     }
                     else 
                     {
                         s = s + "I";
                     }

                     n = n - 1;
                 }
                 if (n >= 4 && n<5)
                 {
                     if (s == null)
                     {
                         s = new string("IV");
                     }
                     else
                     {
                         s = s + "IV";
                     }
                     n = n - 4;
                 }
                 if (n >= 5 && n < 9)
                 {

                     if (s == null)
                     {
                         s = new string("V");
                     }
                     else
                     {
                         s = s + "V";
                     }

                     n = n - 5;
                 }
                 if (n >= 9 && n<10)
                 {
                     if (s == null)
                     {
                         s = new string("IX");
                     }
                     else
                     {
                         s = s + "IX";
                     }
                     n = n - 9;
                 }
                 if (n >= 10 && n < 40)
                 {

                     if (s == null)
                     {
                         s = new string("X");
                     }
                     else
                     {
                         s = s + "X";
                     }

                     n = n - 10;
                 }
                 if (n >= 40 && n<50)
                 {
                     if (s == null)
                     {
                         s = new string("XL");
                     }
                     else
                     {
                         s = s + "XL";
                     }
                     n = n - 40;
                 }
                 if (n >= 50 && n < 90)
                 {

                     if (s == null)
                     {
                         s = new string("L");
                     }
                     else
                     {
                         s = s + "L";
                     }

                     n = n - 50;
                 }
                 if (n >=90 && n< 100)
                 {
                     if (s == null)
                     {
                         s = new string("XC");
                     }
                     else
                     {
                         s = s + "XC";
                     }
                     n = n - 90;
                 }
                 if (n >= 100 && n < 400)
                 {

                     if (s == null)
                     {
                         s = new string("C");
                     }
                     else
                     {
                         s = s + "C";
                     }

                     n = n - 100;
                 }
                 if (n>= 400 && n<500)
                 {
                     if (s == null)
                     {
                         s = new string("CD");
                     }
                     else
                     {
                         s = s + "CD";
                     }
                     n = n - 400;
                 }
                 if (n >= 500 && n < 900)
                 {
                     if (s == null)
                     {
                         s = new string("D");
                     }
                     else
                     {
                         s = s + "D";
                     }

                     n = n - 500;
                 }
                 if (n >= 900 && n < 1000)
                 {
                     if (s == null)
                     {
                         s = new string("CM");
                     }
                     else
                     {
                         s = s + "CM";
                     }
                     n = n - 900;
                 }
                 if (n >= 1000)
                 {
                     if (s == null)
                     {
                         s = new string("M");
                     }
                     else
                     {
                         s = s + "M";
                     }

                     n = n - 1000;
                 }

             }
             return s;*/
            if (num <= 0 || num >= 4000) { return ""; }

            string thousands = ROMAN_THOUSANDS[num / 1000];
            num %= 1000; // now num is between 0 and 999

            string hundreds = ROMAN_HUNDREDS[num / 100];
            num %= 100; // now num is between 0 and 99

            string tens = ROMAN_TENS[num / 10];
            num %= 10; // now num is between 0 and 9

            string ones = ROMAN_ONES[num];

            string romanNumber = $"{thousands}{hundreds}{tens}{ones}";
            return romanNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1994));
        }
    }
}
