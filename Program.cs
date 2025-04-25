using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex3redo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user for sting
            Console.WriteLine("Enter string");
            //get input for string
            string input = Console.ReadLine();

            //enter loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("1 - reverse string\n2 - count number of vowels\n3 - see if string is a palindrome\n4 - exit");
                //get menu choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //enter switch based on choice
                switch (choice)
                {
                    case 1:
                        //enter method to reverse string
                        Console.WriteLine(ReverseString(input));
                        break;
                    case 2:
                        //enter method to count vowels
                        Console.WriteLine($"There are {CountVowels(input)} vowels in {input}");
                        break;
                    case 3:
                        //enter method to see if string is palindrome
                        Console.WriteLine($"Palindrom is: {IsPalindrome(input)}");
                        break;
                    case 4:
                        //exit
                        return;
                    default:
                        //display error message
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        //method to reverse string
        static string ReverseString(string input)
        {
            //declare reverse string
            string rev = "";

            //loop through the last character to the first character
            for (int i = input.Length - 1; i >= 0; i--)
            {
                rev += input[i];
            }

            //return reverse string
            return rev;
        }

        //method to count vowels
        static int CountVowels(string input)
        {
            //declare counter
            int counter = 0;

            //declare string of vowels
            string vowels = "aeiou";

            //loop through all characters of input
            foreach (char c in input.ToLower())
            {
                //loop through all vowels
                foreach (char ch in vowels)
                {
                    //see if letter is a vowel
                    if (c == ch)
                    {
                        //increase vowel counter
                        counter++;
                    }
                }
            }

            //return number of vowels
            return counter;
        }

        //method to see if string is palindrome
        static bool IsPalindrome(string input)
        {
            //declare boolean
            bool test = false;
            //see if string is palindrome
            if (input == ReverseString(input))
            {
                test = true;
            }
            return test;
                    
        }
    }
}
