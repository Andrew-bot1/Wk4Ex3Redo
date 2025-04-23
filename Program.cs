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
                        CountVowels(input);
                        break;
                    case 3:
                        //enter method to see if string is palindrome
                        IsPalindrome(input);
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
            string rev="";

            //loop through the last character to the first character
            for (int i = input.Length; i == 0; i--)
            {
                rev += input[i];
            }

            //return reverse string
            return rev;
        }
        //method to count vowels
        static void CountVowels(string input)
        {

        }

        //method to see if string is palindrome
        static void IsPalindrome(string input)
        {

        }
    }
}
