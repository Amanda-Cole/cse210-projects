using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("help");
    
        // List<Goal> goals = new List<Goal>();

        Console.Clear();

        Console.WriteLine("Welcome to the new program");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. List");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Record");
        Console.WriteLine("6. Quit");

        string _firstChoice = Console.ReadLine();
        switch (_firstChoice)
        {
            case "1":
                Console.WriteLine("chose one");
                Console.WriteLine("   1: Simple goal\n   2: Eternal Goal\n   3: Checklist goal");
                string _secChoice = Console.ReadLine();
                RunChoice(_secChoice);
                break;
            case "2":
                Console.WriteLine("List goals");
                
                break;
            case "3":
                Console.WriteLine("Save to txt");
                break;
            case "4":
                Console.WriteLine("Load from txt");
                break;
            case "5":
                Console.WriteLine("Record a completed goal");
                break;
            case "6":
                Console.WriteLine("Quit !Thanks  for using our program!");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Error, please enter a valid choice.");
                Thread.Sleep(3000);
                break;
        
        }
    }


    public static void RunChoice(string x)
    {
        Console.Clear();
        Goal goal = null;

        Console.WriteLine("Name your goal:");
        string _goalName=Console.ReadLine();
        Console.WriteLine("Describe your goal:");
        string _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int _points=int.Parse(Console.ReadLine());

        if (x == "1")
        {
            Console.WriteLine("final step to call class");
            goal = new SimpleGoal(_goalName,_goalDescription,_points);
            Console.WriteLine(_goalName, _goalDescription, _points);
        }    
        else if (x == "2")
        {
            Console.WriteLine("Eternal Goal Chosen");
            
        }
        else if (x == "3")
        {
            Console.WriteLine("CheckList Goal chosen");
           
        }
        else
        {
            Console.WriteLine("Error.Please try agin");
            Thread.Sleep(3000);
        }
    }






}