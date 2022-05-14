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
using System.Security.Cryptography.X509Certificates;
using System.Collections.Immutable;

namespace Contacts
{
    class Result
    {

        /*
         * Complete the 'contacts' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts 2D_STRING_ARRAY queries as parameter.
         */

        public static List<int> contacts(List<List<string>> queries)
        {
            List<string> contact = new List<string>();
            HashSet<string> keys = new HashSet<string>();  
            keys.Select(x => x.ToString());
            List<int> result = new List<int>();
            foreach (var v in queries)
            {
                if (v[0] == "add")
                {
                    keys.Add(v[1]);
                }
                if (v[0]=="find")
                {
                    var flag = keys.Where(x => x.StartsWith(v[1])).ToList();
                    result.Add(flag.Count);
                }

            }
            return result;
        }

       /* private static int findthecontact(string v, List<string> Contact)
        {
            int count = 0;
           foreach(var i in Contact)
            {
                var result = i.StartsWith(v);
                if(result)
                {
                    count++;
                }
            }
           return count;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {

            int queriesRows = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<string>> queries = new List<List<string>>();

            for (int i = 0; i < queriesRows; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
            }

            List<int> result = Result.contacts(queries);

            Console.WriteLine(String.Join("\n", result));
            StringBuilder sb = new StringBuilder();
            

           
        }
    }
}
