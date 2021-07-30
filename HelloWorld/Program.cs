using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var isQuit = false;
            var numbersList = new List<int>()
            {

            };
            

            while (!isQuit)
            {
                Console.WriteLine("Type a number or QUIT to exit: ");
                var inputString = Console.ReadLine();
                if (inputString == "QUIT")
                {
                    isQuit = true;
                }
                else
                {
                    numbersList.Add(Convert.ToInt32(inputString));
                }
            }

            foreach (var display in GetUniqueNumbers(numbersList))
            {
                Console.WriteLine(display);
            }
        }

        public static List<int> GetUniqueNumbers(List<int> numbersList)
        {
            var displayNumbersList = new List<int>();
            foreach (var unique in numbersList)
            {
                if (!displayNumbersList.Contains(unique))
                {
                    displayNumbersList.Add(unique);
                }
            }

            return displayNumbersList;
        }
    }
}