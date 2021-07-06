using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Type a number between 1 and 10");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <=10)
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }

            /*2 - Write a program which takes two numbers from the console and displays the maximum of the two.*/

            Console.WriteLine("Type a number");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number2 > number1 ? number2 : number1);

            /*3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.*/

            Console.WriteLine("\nType the height of the image");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the width of the image");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(height > width ? "The image is a portrait\n" : "The image is a landscape\n");

            /*4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.*/

            var licenseSuspended = false;
            var demeritPoints = 0;

            while (!licenseSuspended)
            {
                Console.WriteLine("Type the speed limit");
                var speedLimit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type the speed of the car");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                if (speedLimit > carSpeed)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    demeritPoints += (carSpeed - speedLimit) / 5;
                    Console.WriteLine("You have received " + demeritPoints + " demerit points so far\n");
                }

                if (demeritPoints>=12)
                {
                    licenseSuspended = true;
                    Console.WriteLine("Your license has been suspended");
                }
            }

            
        }
    }
}