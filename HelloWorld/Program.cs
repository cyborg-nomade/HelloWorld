using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\urielf\test.txt";

            File.Copy(path,@"c:\USER\urielf\testCopy.txt",true);
            File.Delete(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("No file here");
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                
            }
        }
    }
}
