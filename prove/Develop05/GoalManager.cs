// create list, function to add to list, save to txt, load from txt
public class GoalManager
{

    private List<Goal> goals = new List<Goal>();

    public GoalManager()
    {
    }

    public void AddGoal(string type, string goalName, string goalDescription, int points)
    {
        Goal g = null;
        if (type == "1")
        {
            g = new SimpleGoal(goalName,goalDescription,points);   
        }    
        else if (type == "2")
        {
            Console.WriteLine("Eternal Goal Chosen");
            g = new EternalGoal(goalName,goalDescription,points); 
        }
        else if (type == "3")
        {
            Console.WriteLine("CheckList Goal chosen");
        }
        else
        {
            Console.WriteLine("Error.Please try agin");
            Thread.Sleep(3000);
        }

        if(g != null) {
            goals.Add(g);
        }
    }

    public void MarkComplete(int numberToComplete)
    {
        Goal goalToComplete = goals[numberToComplete-1];
        goalToComplete.CompleteGoal();
        // Console.Write("Enter Goal Name: ");
        // string name = Console.ReadLine();
        // Goal goal = library.g.Find(g => g.Name == name);
        // if (goal != null)
        // {
        //     goal.IsComplete = true;
        //     library.Save();
        // }
        // else
        // {
        //     Console.WriteLine("Goal not found.");
        // }
    }

    public void DisplayGoals()
    {
        int i = 1;
        foreach(Goal g in goals){
            g.DisplayGoal(i.ToString());
            i++;
        }
    }

    public void DisplayGoalPointTotal()
    {
        int total = 0;
        foreach(Goal g in goals){
            total = total + g.GetCompletedPoints();
        }

        Console.WriteLine($"You have {total} points");
    }
    public void Load(string filename)
    {
        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4 && int.TryParse(parts[2], out int points) && bool.TryParse(parts[3], out bool isComplete))
                    {
                        goals.Add(new Goal(parts[0], parts[1], points) { IsComplete = isComplete });
                    }
                }
            }
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.IsComplete}");
            }
        }
    }

}



    // attributes for ManageGoals
    // each goal a new page in goalList
    

    // public ManageGoals{

    // }

    // public void Display()
    // {
    //     foreach(Goal g in _libGoals){
    //         g.DisplayGetFullEntry();
    //     }

    // }


















    // public virtual string LoadFromFile()
    // {
    //     Console.WriteLine("What file would you like to load? (goalFile.txt) ");
    //     string filename = Console.ReadLine();

    //     string[] lines = System.IO.File.ReadAllLines(filename);
    //     string line = "";

    //     foreach( string x in lines)
    //     {
    //         string[] parts = line.Split("%");
    //         string _listGoalCompleted = parts[0];
    //         string _listGoalName = parts[1];
    //         string _listGoalDescription = parts[2];
    //         string _listGoalPoints = parts[3];
    //         string _listGoalTimesCompl = parts[4];
    //         string _listGoalTotalTimes = parts [5];
    //         string _listGoalBonusPoints = parts[6];
    //         // Save each split to Library when loaded? Library method? Save method?  Display goals to view?
    //     }
    // }
