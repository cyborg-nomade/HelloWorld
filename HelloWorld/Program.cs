using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,10));
            }

            /*for (int i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }
            Console.WriteLine();*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0,26)));
            }
            Console.WriteLine();*/

            const int passwordLength = 8;

            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));
            }

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}