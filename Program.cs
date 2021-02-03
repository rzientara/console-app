using System;

namespace console_app
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program.\n[1] name\n[2] area\n[3] mpg\n[4] string search\n[q] quit");
            string option = Console.ReadLine();
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
                Mpg();
            }
        }

        static void Name()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
        static void Area()
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            int intLength;
            while (!(Int32.TryParse(length, out intLength)))
            {
                Console.WriteLine("Incorrect input. What is the length of the rectangle?");
                length = Console.ReadLine();
            }

            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            int intwidth;
            while (!(Int32.TryParse(width, out intwidth)))
            {
                Console.WriteLine("Incorrect input. What is the width of the rectangle?");
                width = Console.ReadLine();
            }

            string area = (intLength * intwidth).ToString();
            Console.WriteLine("The area is " + area + ".");
            Console.ReadLine();
        }
        static void Mpg()
        {
            Console.WriteLine("How many miles have you driven?");
            string miles = Console.ReadLine();
            int intMiles;
            while (!(Int32.TryParse(miles, out intMiles)))
            {
                Console.WriteLine("Incorrect input. How many miles have you driven?");
                miles = Console.ReadLine();
            }

            Console.WriteLine("How many gallons of gas have you used?");
            string gallons = Console.ReadLine();
            int intGallons;
            while (!(Int32.TryParse(gallons, out intGallons)))
            {
                Console.WriteLine("Incorrect input. How many gallons of gas have you used?");
                gallons = Console.ReadLine();
            }

            string mpg = (intMiles / intGallons).ToString();
            Console.WriteLine("Your miles-per-gallon is " + mpg + ".");
            Console.ReadLine();
        }
    }

}
