using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;

            float price;

            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            price = isGoldCustomer ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's summer.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's spring.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's winter");
                    break;

                default:
                    Console.WriteLine("No season");
                    break;
            }
        }
    }
}