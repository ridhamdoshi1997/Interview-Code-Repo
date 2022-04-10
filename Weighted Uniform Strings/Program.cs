using System;

namespace Weighted_Uniform_Strings
{
    class Program
    {
       /* static string[] weightedUniformStrings(string s, int[] queries)
        {
            
        }*/
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            /*int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            string[] result = weightedUniformStrings(s, queries);

            Console.WriteLine(string.Join("\n", result));*/
            char[] charArray = s.ToCharArray();
            int total = 0;
            int[] temp = new int[s.Length];
            int j = 0;
            for (int i = 0; i < charArray.Length-1; i++)
            {
                //temp[j] = charArray[i]-'a'+1;
                if (charArray[i] == charArray[i - 1])
                {
                   
                    total = (charArray[i] - 'a' + 1) + (charArray[i + 1] - 'a' + 1);
                    //j++;
                    temp[j] = total;
                        

                }
               
                else
                {
                    temp[j] = charArray[i] - 'a' + 1;
                }
                j++;
                total = 0;
            }
            Console.WriteLine(total);
        }
    }
}
