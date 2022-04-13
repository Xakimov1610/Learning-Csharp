using System;

// The namespace makes it easier to organize our application and 
// avoid name collisions with other code
namespace HelloWorld
{
    // In .NET our program is contained within its own class
    class Program
    {
        // The main function is the entry point into our app
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");

            // create a string variable and ask the user for some input
            string str = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str);
        }
    }
}