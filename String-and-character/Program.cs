/*
 16.7 Write a program that uses regular expressions to convert the first letter of every word to uppercase.
 Have it do this for an arbitarry string input by the user. 
 */

using System;

namespace String_and_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;

            Console.WriteLine("***************");
            Console.WriteLine("Write any sentence to convert the first letter of every word to Uppercase");
            Console.WriteLine("***************\n");

            Console.WriteLine("Enter a sentence: ");
            str1 = Console.ReadLine();

            str1 = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str1.ToLower());

            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
