using System;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            var divisibleBy3 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0)
                {
                    divisibleBy3++;
                }
            }

            Console.WriteLine(divisibleBy3);

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            var isOK = false;
            var sum = 0;

            while (!isOK)
            {
                Console.WriteLine("Type a number or OK to exit");
                var answer = Console.ReadLine();

                if (answer=="OK")
                {
                    isOK = true;
                }
                else
                {
                    sum += Convert.ToInt32(answer);
                    Console.WriteLine(sum);
                }
            }

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Type a number to calculate a factorial");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(number + "! = " + factorial);

            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var random = new Random();

            var secretNumber = random.Next(1, 10);

            Console.WriteLine(secretNumber);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Try to guess the secret number:");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong answer, try again!");
                }

                if (i==3 && guess!=secretNumber)
                {
                    Console.WriteLine("You lost.");
                }
            }

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Type a series of numbers separated by a comma");
            var answerString = Console.ReadLine();

            var numbersArray = answerString.Split(',');
            var maximum = 0;

            foreach (var numberString in numbersArray)
            {
                var currentNumber = Convert.ToInt32(numberString);

                if (currentNumber>maximum)
                {
                    maximum = currentNumber;
                }
            }

            Console.WriteLine("The highest number is: "+ maximum);
        }
    }
}