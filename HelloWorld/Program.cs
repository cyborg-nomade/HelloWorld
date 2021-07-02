using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a+b);
            Console.WriteLine(a/b);
            Console.WriteLine((float)a/(float)b);

            var a1 = 1;
            var b2 = 2;
            var c3 = 3;

            Console.WriteLine(a1+b2*c3);
            Console.WriteLine((a1+b2)*c3);

            Console.WriteLine(a1>b2);
            Console.WriteLine(a1==b2);
            Console.WriteLine(a1!=b2);
            Console.WriteLine(!(a1!=b2));

            Console.WriteLine(c3 > b2 && c3 > a1);
            Console.WriteLine(c3 > b2 && c3 == a1);
            Console.WriteLine(c3 > b2 || c3 == a1);


        }
    }
}
