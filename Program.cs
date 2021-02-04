﻿using System;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
        }
    }

    class Menu
    {
        static Menu()
        {
            string option = "";

            while (!(option == "q"))
            {
                Console.Clear();

                Console.WriteLine("Choose a program.\n[1] name\n[2] area\n[3] mpg\n[4] string search\n[q] quit");
                option = Console.ReadLine();
                
                if (option == "1")
                {
                    Name();
                }
                else if (option == "2")
                {
                    Area();
                }
                else if (option == "3")
                {
                    MPG();
                }
                else if (option == "4")
                {
                    StringSearch();
                }
            }
        }
        static void Name()
        {
            Console.Clear();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello, " + name + "!");
            
            Console.ReadLine();
        }
        static void Area()
        {
            Console.Clear();

            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            
            int intLength;
            while (!(Int32.TryParse(length, out intLength)))
            {
                Console.WriteLine("\nIncorrect input. What is the length of the rectangle?");
                length = Console.ReadLine();
            }

            Console.WriteLine("\nWhat is the width of the rectangle?");
            string width = Console.ReadLine();
            
            int intwidth;
            while (!(Int32.TryParse(width, out intwidth)))
            {
                Console.WriteLine("\nIncorrect input. What is the width of the rectangle?");
                width = Console.ReadLine();
            }

            string area = (intLength * intwidth).ToString();
            Console.WriteLine("\nThe area is " + area + ".");
            
            Console.ReadLine();
        }
        static void MPG()
        {
            Console.Clear();

            Console.WriteLine("How many miles have you driven?");
            string miles = Console.ReadLine();
            
            int intMiles;
            while (!(Int32.TryParse(miles, out intMiles)))
            {
                Console.WriteLine("\nIncorrect input. How many miles have you driven?");
                miles = Console.ReadLine();
            }

            Console.WriteLine("\nHow many gallons of gas have you used?");
            string gallons = Console.ReadLine();
            
            int intGallons;
            while (!(Int32.TryParse(gallons, out intGallons)))
            {
                Console.WriteLine("\nIncorrect input. How many gallons of gas have you used?");
                gallons = Console.ReadLine();
            }

            string mpg = (intMiles / intGallons).ToString();
            Console.WriteLine("\nYour miles-per-gallon is " + mpg + ".");
            
            Console.ReadLine();
        }
        static void StringSearch()
        {
            Console.Clear();

            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
            Console.WriteLine("Enter search terms.");
            string term = Console.ReadLine();

            if (sentence.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("\nTerm found.");
            }
            else
            {
                Console.WriteLine("\nTerm not found.");
            }

            Console.ReadLine();
        }
    }
}
