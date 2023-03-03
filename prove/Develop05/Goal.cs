public abstract class Goal
{
    private string _goalName="";
    private string _goalDescription = "";
    private int _points=0;

    List<string>_libGoals = new List<string>();

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
// constructor
public Goal (string goalName, string goalDescription, int points)
{
    _goalName=goalName;
    _goalDescription = goalDescription;
    _points = points;
}
// abstract method to show display variations
public abstract string IsComplete();

}