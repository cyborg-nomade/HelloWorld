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
            var builder = new StringBuilder();
            var builder2 = new StringBuilder("Hello World");

            builder.Append('-', 10)
                .AppendLine()
                .Append("Headers")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            builder.Remove(0, 10);
            Console.WriteLine(builder);

            builder.Insert(0, new string('-',10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: "+ builder2[0]);

        }

    }
}