using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace C_sharp_console
{
    class Program
    {
        static string funnyString(string s)
        {
            char[] chars = s.ToArray();
            
            byte[] bytesString = Encoding.ASCII.GetBytes(s);
            Array.Reverse(chars);
            int[] diffString = new int[chars.Length-1];
            int[] diffReverseString = new int[chars.Length - 1];
            string reverseString = new string(chars);
            byte[] bytesReverseString = Encoding.ASCII.GetBytes(reverseString);
            //int max_diff = bytesString[1] - bytesString[0];
            for (int i=0;i<bytesString.Length-1;i++)
            {
                diffString[i]= Math.Abs(bytesString[i + 1] - bytesString[i]); //o(n)
            }
            for (int i = 0; i < bytesReverseString.Length - 1; i++)
            {
                diffReverseString[i] = Math.Abs(bytesReverseString[i + 1] - bytesReverseString[i]); //0(n)
            }
           if(diffString.SequenceEqual(diffReverseString))
            {
                return "Funny";
            }
            else
            {
                return "Not Funny";
            }
            //return reverseString;

           
        }

        static void Main(string[] args)
        {
           
          // Console.WriteLine("Please enter the string");

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = funnyString(s);

                Console.WriteLine(result);
            }
        }
    }
}
