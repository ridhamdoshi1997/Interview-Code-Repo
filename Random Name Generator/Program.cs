using System;
using System.Collections.Generic;
using System.Collections;

namespace Random_Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<string> nameList = new List<string> { "Ridham", "Roger", "Jay" ,"Aayushi","Chris","Ankit"};
            Console.WriteLine("Entered Names:");
            foreach (string s in nameList)
            Console.WriteLine(s);
            for (int i = 0; i < nameList.Count; i++)
            {
                string temp = nameList[i];
                Random ran = new Random();
                int ranInd = ran.Next(i, nameList.Count);
                nameList[i] = nameList[ranInd];
                nameList[ranInd] = temp;
            }

            Console.WriteLine("\n Shuffled List:");
            foreach (string s in nameList)
            Console.WriteLine(s);

        }
    }
}
