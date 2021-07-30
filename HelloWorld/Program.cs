using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\USERS\urielf\test");

            //var files = Directory.GetFiles(@"C:\Users\urielf\Source\Repos", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"c:\Users\urielf\Source", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
