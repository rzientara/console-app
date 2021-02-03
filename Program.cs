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
        }

        static void Name()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
    }

}
