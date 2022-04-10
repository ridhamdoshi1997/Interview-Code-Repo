using System;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
           string  lowerString = s.ToLower();
            int[] count = new int[26];
            char[] charArray = lowerString.ToCharArray();
           for(int i=0;i<s.Length;i++)
            {
                if(charArray[i]>='a' && charArray[i]<='z')
                {
                    count[charArray[i] - 'a']=1;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 1)
                {
                   return "not pangram";
                }
            }
          return "pangram";


        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            pangrams(s);
            string result = pangrams(s);
            Console.WriteLine(result);
        }
    }
}
