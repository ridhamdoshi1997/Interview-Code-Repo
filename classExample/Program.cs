using System;

namespace classExample
{
    
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Testing the use of base keyword. Example - 2 * **\n\n");
            bool debug = false;

            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
            myStudent.ShowAge();

            if (debug)
                Console.ReadLine();
        }
    }
}
