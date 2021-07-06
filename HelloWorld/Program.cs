using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            var i=0;
            while (i<10)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}