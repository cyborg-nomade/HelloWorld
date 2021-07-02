using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
            
        }
    }
}
