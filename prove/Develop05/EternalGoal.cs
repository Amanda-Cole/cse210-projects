public class EternalGoal:Goal
{
    public EternalGoal(string goalName,string goalDescription,int points):base(goalName,goalDescription,points)
    {}

    public override void DisplayGoal(string number)
    {
       Console.WriteLine(number + " Eternal");
    }

    public override void CompleteGoal()
    {
        Console.WriteLine("Eternal goal completed");
    }

    public override int GetCompletedPoints()
    {
        return base.GetCompletedPoints();
    }
}