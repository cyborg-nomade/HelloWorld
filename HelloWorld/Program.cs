using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 0; i--)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}