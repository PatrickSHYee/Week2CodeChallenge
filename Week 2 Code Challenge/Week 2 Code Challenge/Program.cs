using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("{0} - {1}", i, FizzBuzz(i));
            }

            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('a', "Sally sells seashells down by the seeshore. She's from Sussex.");
        }

        /// <summary>
        /// Takes a number sees if it is divisible by 3, 5, or both. Prints a fizz, buzz, and fizzbuzz.
        /// </summary>
        /// <param name="number">Prints a fizz, buzz, and fizzbuzz.</param>
        /// <returns></returns>
        static string FizzBuzz(int number)
        {
            string returnString = null;

            if (number % 5 == 0)
            {
                returnString += "Fizz";
            }
            if (number % 3 == 0)
            {
                returnString += "Buzz";
            }
            if (returnString == null)
            {
                returnString += number.ToString();
            }
            return returnString;
        }

        /// <summary>
        /// This takes a letter and searches a string for that letter.
        /// </summary>
        /// <param name="letter">searching letter</param>
        /// <param name="inString">string to be searched</param>
        static void LetterCounter(char letter, string inString)
        {
            // the counters
            int num_LowerCase = 0;
            int num_UpperCase = 0;

            // sees if there is the letter in the instring
            for (int i = 0; i < inString.Length; i++)
            {
                // searches for the lower letter
                if (inString[i] == letter.ToString().ToLower()[0])
                {
                    num_LowerCase++;
                }
                // sees if the index of inString is an Upper case.
                if (inString[i] == letter.ToString().ToUpper()[0])
                {
                    num_UpperCase++;
                }
            }

            Console.WriteLine("Input: {0}\nNumber of lowercase {1}s found: {2}\nNumber of UPPERCASE {3} found: {4}\nTotal number of {5}s found: {6}",
                inString, letter, num_LowerCase, letter.ToString().ToUpper(), num_UpperCase, letter, num_LowerCase + num_UpperCase);
        }
    }
}
