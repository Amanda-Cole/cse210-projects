// things only SimpleGoal needs to do, isComplete

public class SimpleGoal:Goal
{
    public SimpleGoal(string goalName,string goalDescription,int points):base(goalName,goalDescription,points)
    {
        
    }
    
    public override void DisplayGoal(string number)
    {
       Console.WriteLine(number + " Simple");
    }

    public override void CompleteGoal()
    {
        IsComplete = true;
        Console.WriteLine("Simple goal completed");
    }

    public override int GetCompletedPoints()
    {
        return base.GetCompletedPoints();
    }
}  
   
// //     public override string IsComplete();
// //     {
        
        
// //     }


