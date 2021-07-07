using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

                If no one likes your post, it doesn't display anything.
                If only one person likes your post, it displays: [Friend's Name] likes your post.
                If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
                If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
                Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.*/

            var isExit = false;
            var namesList = new List<string>()
            {

            };

            while (!isExit)
            {
                Console.WriteLine("Type a name: ");
                var newName = Console.ReadLine();

                if (newName!="")
                {
                    namesList.Add(newName);
                }
                else
                {
                    isExit = true;
                }
            }

            switch (namesList.Count)
            {
                case 0:
                    Console.WriteLine("");
                    break;

                case 1:
                    Console.WriteLine(namesList[0] + " likes your post");
                    break;

                case 2:
                    Console.WriteLine(namesList[0] + " and " + namesList[1] + " like your post");
                    break;

                default:
                    Console.WriteLine(namesList[0] + " and " + namesList[1] + " and " + (namesList.Count-2) + " other people like your post");
                    break;
            }

            /*2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.*/

            Console.WriteLine("Write your name: ");
            var input = Console.ReadLine();
            if (input != null)
            {
                var name = input.ToCharArray();
                Array.Reverse(name);
                var reversedName = new string(name);
                Console.WriteLine(reversedName + " is your reversed name");
            }

            /*3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/

            var numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a new number: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                while (numbers.Contains(inputNumber))
                {
                    Console.WriteLine("This number has already been entered, type another: ");
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                }

                numbers[i] = inputNumber;
            }

            Array.Sort(numbers);
            Console.WriteLine("This is your sorted array: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            /*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/

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

            var displayNumbersList = new List<int>();

            foreach (var unique in numbersList)
            {
                if (!displayNumbersList.Contains(unique))
                {
                    displayNumbersList.Add(unique);
                }
            }

            foreach (var display in displayNumbersList)
            {
                Console.WriteLine(display);
            }

            /*5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.*/
            var isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Type a list of 5 comma-separated numbers");
                var inputString2 = Console.ReadLine();

                var numberList = new List<int>()
                {

                };

                if (inputString2 != "")
                {
                    var inputStringArray = inputString2.Split(',');
                    foreach (var s in inputStringArray)
                    {
                        numberList.Add(Convert.ToInt32(s));
                    }
                }
                else
                {
                    numberList.Clear();
                }

                if (numberList.Count < 5 || !numberList.Any())
                {
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }
                else
                {
                    isValid = true;
                    numberList.Sort();
                    Console.WriteLine("The three smallest numbers are:" + numberList[0] + ","+ numberList[1]+","+numberList[2]);
                }
            }
        }
    }
}