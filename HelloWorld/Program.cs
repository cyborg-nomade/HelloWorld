using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            return new string(array);

        }
    }
}