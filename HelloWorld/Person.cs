using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + FirstName + " " + LastName);
        }
    }
}