using System;
using System.Collections.Generic;
using System.Globalization;
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
            /*1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
            Console.WriteLine("Type a sequence of numbers separated by a dash (-)");
            var seqSeparatedByDash = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(seqSeparatedByDash))
            {
                var numbers = seqSeparatedByDash.Split('-');
                var firstNumber = int.Parse(numbers[0]);
                var notConsecutive = false;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (firstNumber+i!=int.Parse(numbers[i]))
                    {
                        notConsecutive = true;
                    }
                }

                Console.WriteLine(notConsecutive ? "Not Consecutive" : "Consecutive");
            }
            else
            {
                Console.WriteLine("Empty sequence");
            }

            /*2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/

            Console.WriteLine("Type a sequence of numbers separated by a dash (-)");
            var seqSeparatedByDash2 = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(seqSeparatedByDash2))
            {
                var numbers = seqSeparatedByDash2.Split('-');
                bool hasDuplicate = numbers.Length != numbers.Distinct().Count();

                Console.WriteLine(hasDuplicate ? "Duplicate" : "No Duplicates");
            }
            else
            {
                Console.WriteLine("");
            }

            /*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.*/

            Console.WriteLine("Type a valid 24-hour time hour (00:00 - 23:59)");
            var timeValue = Console.ReadLine();
            DateTime convertedTime;

            Console.WriteLine(DateTime.TryParseExact(timeValue, "HH:mm", new CultureInfo("en-US"), DateTimeStyles.None,
                out convertedTime)
                ? "Ok"
                : "Invalid Time");


            /*4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/

            Console.WriteLine("Type a few words separated by space");
            var seqWords = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(seqWords))
            {
                var resultString = seqWords.ToLower();
                TextInfo info = CultureInfo.CurrentCulture.TextInfo;
                resultString = info.ToTitleCase(resultString).Replace(" ", string.Empty);
                Console.WriteLine(resultString);
            }
            else
            {
                Console.WriteLine("Empty input");
            }


            /*5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.*/

            Console.WriteLine("Type one word in English");
            var oneWord = Console.ReadLine();
            var ctVowel = 0;

            if (!string.IsNullOrWhiteSpace(oneWord)){
                foreach (var c in oneWord)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        ctVowel++;
                    }
                }

                Console.WriteLine(ctVowel);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}