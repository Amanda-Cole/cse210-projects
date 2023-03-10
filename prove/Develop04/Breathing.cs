public class Breathing : Activity
{
    public Breathing()
    :base( "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public override void DisplayActivity()
    {
        base.DisplayActivity();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(Duration);

        while (currentTime < futureTime)
        {
            Console.WriteLine();           
            Console.Write("Breath In... ") ;
            TimerUp();
            Console.Write("\b \b");
            Console.WriteLine();
            Console.WriteLine("and");
            
            Console.Write("Breath Out... ");
            TimerDown(6);
            Console.Write("\b \b");
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
        DisplayEnd();
    }
}