using System;

class Program
{
    static void Main(string[] args)
    {
        // Main page for options
        string _userInputChoice ="0" ;
        // string _duration = "";

        while (_userInputChoice != "5"){

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to the mindfulness program");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Please select from the following:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Grounding");
            Console.WriteLine("5. Quit");

            _userInputChoice = (Console.ReadLine());
            Console.WriteLine();

            Activity activity = null;
            if (_userInputChoice == "1")
            {
                activity = new Breathing();
            }
            else if (_userInputChoice == "2")
            {
                activity = new Reflection();
            }
            else if (_userInputChoice == "3")
            {
                activity = new Listing();
            }
            else if (_userInputChoice == "4")
            {
                activity = new Grounding();
            }

            else{
                Console.Clear();
            }

            activity.DisplayActivity();
            //Activity activity = new Activity(_duration);

        }
    }
}