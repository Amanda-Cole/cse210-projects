public abstract class Goal
{
    private string _goalName="";
    private string _goalDescription = "";
    private int _points=0;
  
    private bool _isComplete=false;

    // completed boolean?

    // getters
    protected string GoalName{
        get{
            return _goalName;
        }
    }
    protected string GoalDescription{
        get{
            return _goalDescription;
        }
    }
    protected int Points{
        get{
            return _points;
        }
    }

    protected bool IsComplete{
        get{
            return _isComplete;
        }
        set{
            _isComplete = value;
        }
    }

    // constructor
    public Goal (string goalName, string goalDescription, int points)
    {
        _goalName=goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract void CompleteGoal();

    public abstract void DisplayGoal(string number);

    public virtual int GetCompletedPoints(){
        if(_isComplete){
            return _points;
        } else {
            return 0;
        }
    }
}
// abstract method to show display
// // public virtual void DisplayGoal(string goalName, string goalDescription, int points)
// // {
// //    Console.WriteLine($"[ ] {goalName} ({goalDescription}) {points}");
// // }

// // public abstract string IsComplete();
// }

// CHAT GPT*************************************class Goal
// {
//     private string _name { get; set; }
//     private string _description { get; set; }
//     private int _points { get; set; }
//     private bool IsComplete { get; set; }

//     public Goal(string name, string description, int points)
//     {
//         _name = name;
//         _description = description;
//         _points = points;
//         IsComplete = false;
//     }

//     public override string ToString()
//     {
//         string checkbox = IsComplete ? "[X]" : "[ ]";
//         return $"{checkbox} {Name} ({Points} pts) - {Description}";
//     }
// }