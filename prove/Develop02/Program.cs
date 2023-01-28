using System;

class Program
{
    static void Main(string[] args)
    {
        // alc set variables for input
        int choice = (-1);
        // create new Journal so we can add pages - choice 1 runs AddPage method in CLASS JOURNAL
        Journal j = new Journal();
        
        // alc write if statement for input
        // function for menu choices
        while (choice !=5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Delete an Entry");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                j.AddPage();
            }
            else if (choice == 2) {
                j.Display();
            }
            else if(choice == 3){
                j.Load();
            }
            else if(choice == 4){
                j.Save();
                Console.WriteLine ("You saved your file");
            }
            else if(choice == 6){
                j.Delete();
            }
           
        }
        Console.WriteLine("Thanks for writing today!");

    }
}