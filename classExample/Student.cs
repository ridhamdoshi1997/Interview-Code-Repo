using System;
using System.Collections.Generic;
using System.Text;

namespace classExample
{
    class Student: Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
}
