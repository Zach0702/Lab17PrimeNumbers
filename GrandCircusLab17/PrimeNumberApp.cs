using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GrandCircusLab17
{
    public class PrimeNumberApp
    {
        public static void RunApp()
        {
            int number = 1;
            int counter = 0;
            int loopBreakerOption = ' ';
            int userNumber = 0;
            List<int> usersPrimeNumberSelction = new List<int>();
            List<int> primeNumberResults = new List<int>();



            Console.WriteLine("Let's locate some primes!");
            Console.WriteLine();
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

            do
            {
           
                do
                {
                    Console.WriteLine("Which prime number are you looking for? ");
                    userNumber = IsValidPrimeNumber(Console.ReadLine());
                    if (userNumber < 1)
                    {
                        Console.WriteLine("ERROR: not a valid entry for prime number");
                        Console.WriteLine("Must be a number equal to or greater than one");
                        Console.WriteLine();
                    }
                   } while (userNumber < 1);
                PrimeNumber test = new PrimeNumber();
                while (true)
                {
                    number++;
                    if (test.isPrimeNumber(number))
                    {
                        counter++;
                    }
                    if (counter == userNumber)
                    {
                        Console.WriteLine($"The number {userNumber} prime is {number}");
                        break;
                    }
                }
                usersPrimeNumberSelction.Add(userNumber);
                primeNumberResults.Add(number);

                Console.WriteLine("Do you wish to continue(enter y/n): ");
                loopBreakerOption = IsValidLoopBreaker(Console.ReadLine());
                number = 1;
                counter = 0;
            } while (loopBreakerOption == 'y');

            Console.Clear();
            Console.WriteLine("Here is a summary of your session");
            var joinedList = usersPrimeNumberSelction.Join(primeNumberResults, s => usersPrimeNumberSelction.IndexOf(s), i => primeNumberResults.IndexOf(i), (s, i) => new { sv = s, iv = i }).ToList();
            foreach (var x in joinedList)
            {
                Console.WriteLine($"User prime number selected {x.sv} prime number result {x.iv}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("End of Prime Number Application");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
        public static int IsValidPrimeNumber(string userPrimeEntered)
        {
            bool isInvalidInput = true;
            int validPrimeEntered = 0;

            while (isInvalidInput)
            {
                if (int.TryParse(userPrimeEntered, out validPrimeEntered))
                {
                    isInvalidInput = false;
                }
                else
                {
                    Console.WriteLine($"ERROR: invalid number {userPrimeEntered} entered please try again..");
                    Console.WriteLine("Which prime number are you looking for?");
                    userPrimeEntered = Console.ReadLine();

                }
            }
            return validPrimeEntered;

        }

        public static char IsValidLoopBreaker(string testChar)
        {
            bool isInvalidChar = true;

            Regex pattern = new Regex(@"^[y|n]$");

            char validChar = ' ';

            while (isInvalidChar)
            {
                if (pattern.IsMatch(testChar))
                {
                    isInvalidChar = false;
                    validChar = char.Parse(testChar);
                }
                else
                {
                    Console.WriteLine($"ERROR invalid input of {testChar}  entered please try again");
                    Console.WriteLine("Do you wish to continue(enter y/n): ");
                    testChar = Console.ReadLine();
                }
            }
            return validChar;
        }
    }
}

