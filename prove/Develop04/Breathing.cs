public class Breathing : Activity
{
    int _cycles = 0;
    // int duration = 0;
    // string activityName = "";


    public Breathing()
    :base( "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void DisplayActivity()
    {
        base.DisplayActivity();
        _cycles = Duration / 10;
        // duration = Duration;
        // activityName = ActivityName;

        while (_cycles!=0)
        {    
            Console.WriteLine();           
            Console.Write("Breath In... ") ;
            TimerUp();
            Console.Write("\b \b");
            Console.WriteLine();
            Console.WriteLine("and");
            Thread.Sleep(500);
            
            Console.Write("Breath Out... ");
            TimerDown(6);
            Console.Write("\b \b");
            Console.WriteLine();
            
            _cycles--;
        }
        
        Console.WriteLine();
        DisplayEnd();
        
        // Console.WriteLine();
        // Console.WriteLine($"You completed {Duration} seconds of the {ActivityName}" ) ;
        // Thread.Sleep(3000);
        // Console.Clear();

    }

}