using System;
using System.Collections.Generic;
using System.Text;

namespace classExample
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Person Class");
        }
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
