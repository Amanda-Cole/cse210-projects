// public class ChecklistGoal:Goal
// {
//     private int _duration =0;
//     private int _bonus = 0;

//     public ChecklistGoal(string goalName,string goalDescription,int points,int duration, int bonus):base(goalName,goalDescription,points)
//     {
//         _duration = duration;
//         _bonus = bonus;
//     }

//     public override void GoalDetails()
//     {
//         base.GoalDetails();
//         Console.WriteLine("How many times would you like to complete this goal?");
//         _duration = int.Parse(Console.ReadLine());
//         Console.WriteLine("How many bonus points is this worth?");
//         _bonus = int.Parse(Console.ReadLine());


//         // add to library
//     }



// }