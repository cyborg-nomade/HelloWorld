using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\USERS\urielf\Documents\test.txt";

            /*1- Write a program that reads a text file and displays the number of words.*/
            /*2- Write a program that reads a text file and displays the longest word in the file.*/

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var words = content.Split(' ');

                Console.WriteLine("This file has " + (words.Length) + " words");

                var largestLength = 0;
                var largestWord = "";

                foreach (var word in words)
                {
                    if (word.Length > largestLength)
                    {
                        largestWord = word;
                        largestLength = word.Length;
                    }
                }

                Console.WriteLine("The largest word in this file is: \""+largestWord+"\"");
            }
            else
            {
                Console.WriteLine("This file doesn't exist");
            }
            

            

            
        }
    }
}