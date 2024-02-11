// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the interview. What's your name?");
        bool cooperationb = false;
        bool customerb = false;
        string name = Console.ReadLine();

        Console.WriteLine("\nWell, first off, can you communicate well and effectively work with others? (yes or no)");

        string cooperations = Console.ReadLine();

        if (cooperations == "yes")
        {
            cooperationb = true;
        }
        else
        {
            cooperationb = false;
        }

        Console.WriteLine("\nOkay. Next, are you willing to commit yourself to ensure customer satisfation? (yes or no)");

        string customers = Console.ReadLine();

        if (customers == "yes")
        {
            customerb = true;
        }
        else
        {
            customerb = false;
        }

        if (customerb && cooperationb)
        {
            Console.WriteLine("\nCongratulations " + name + ", you got the job. I\'ll see you first thing Monday.");
        }
        else
        {
            Console.WriteLine("\nUnfortunately, you are not qualified for the job. Have a good day " + name + ".");
        }



    }
}