class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string _firstChoice =" ";
        while(_firstChoice!="6")
        {
            //Console.Clear();
            goalManager.DisplayGoalPointTotal();
            Console.WriteLine("");
            Console.WriteLine("Welcome to the new program");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Record");
            Console.WriteLine("6. Quit");

            _firstChoice = Console.ReadLine();
        
            switch (_firstChoice)
            {
                case "1":
                    Console.WriteLine("chose one");
                    Console.WriteLine("   1: Simple goal\n   2: Eternal Goal\n   3: Checklist goal");
                    string _secChoice = Console.ReadLine();
                    RunChoice(_secChoice, goalManager);
                    break;
                case "2":
                    Console.WriteLine("List goals");
                    goalManager.DisplayGoals();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Save to txt");
                    break;
                case "4":
                    Console.WriteLine("Load from txt");
                    break;
                case "5":
                    Console.WriteLine("Record a completed goal");
                    goalManager.DisplayGoals();
                    Console.WriteLine("Which Goal did you complete? ");
                    string number = Console.ReadLine();
                    goalManager.MarkComplete(int.Parse(number));
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
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
    }

    private static void RunChoice(string x, GoalManager goalManager)
    {
        Console.Clear();
        

        Console.WriteLine("Name your goal:");
        string _goalName=Console.ReadLine();
        Console.WriteLine("Describe your goal:");
        string _goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this worth? ");
        int _points=int.Parse(Console.ReadLine());

        goalManager.AddGoal()
    }
}
// public void UserInputsForGoal()
// {
//         Console.WriteLine("Name your goal:");
//         string _goalName=Console.ReadLine();
//         Console.WriteLine("Describe your goal:");
//         string _goalDescription = Console.ReadLine();
//         Console.WriteLine("How many points is this worth? ");
//         int _points=int.Parse(Console.ReadLine());

// }




