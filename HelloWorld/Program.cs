using System;
using System.Collections.Generic;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Uriel Fiori ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("Uriel", "Uriel Alexis"));

            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("String is null or empty");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("String is null or whitespace");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}