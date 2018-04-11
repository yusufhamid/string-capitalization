/*
 16.7 Write a program that uses regular expressions to convert the first letter of every word to uppercase.
 Have it do this for an arbitarry string input by the user.
 
 2018-04-10 - just some added notes. --chuck
 */

using System;

//namespace String_and_character - namespaces should follow rules for C# identifiers, which is called "Pascal case"
// basically the same as "camelcase", but starts with upper case char instead of lower. --chuck
namespace StringAndCharacter 
{
    class Program
    {
        static void Main(string[] args)
        {
            // local vars should be declared immediately prior to where they are first used, not here at the top.
            //string str1;

            Console.WriteLine("***************");
            Console.WriteLine("Write any sentence to convert the first letter of every word to Uppercase");
            Console.WriteLine("***************\n");

            Console.WriteLine("Enter a sentence: ");
            string str1 = Console.ReadLine();

            // not sure what all the following is for, but I hope there is some reason for it
            str1 = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str1.ToLower());

            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}

// the rest all looks good
