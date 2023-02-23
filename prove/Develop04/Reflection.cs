public class Reflection : Activity
{
    private string _rPrompt;
    List<string> _libPrompt1 = new List<string>();
    List<string> _libFollowPrompt = new List<string>();

    public Reflection():base ("Reflecting Exercise", "This activity will help you reflect on  times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _libPrompt1.Add("Think of a time when you stood up for someone else");
        _libPrompt1.Add("Think of a time when you did something really difficult.");
        _libPrompt1.Add("Think of a time when you helped someone in need.");
        _libPrompt1.Add ("Think of a time when you did something truly selfless.");

        _libFollowPrompt.Add("Why was this experience meaningful to you?");
        _libFollowPrompt.Add("Have you ever done anything like this before?");
        _libFollowPrompt.Add("How did you get started?");
        _libFollowPrompt.Add("How did you feel when it was completed?");
        _libFollowPrompt.Add("What made this time different than other times when you were not as sccessful?");
        _libFollowPrompt.Add("What is your favorite thing about this experience?");
        _libFollowPrompt.Add("What could you learn from this experience that applies to other situations?");
        _libFollowPrompt.Add("What did you learn about yourself through this experience?");
        _libFollowPrompt.Add("How can you keep this experience in mind in the future?");
    }
    public override void DisplayActivity(){
        base.DisplayActivity();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"----{GetRandomPrompt(_libPrompt1)}----");
        Console.WriteLine();
        Console.WriteLine("Press enter when ready to proceed.");
        Console.ReadLine();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(Duration);

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            _rPrompt = GetRandomPrompt(_libFollowPrompt);
            Console.WriteLine(_rPrompt);
            _libFollowPrompt.Remove(_rPrompt);
            Spinner(4);
            currentTime = DateTime.Now;
        }
        DisplayEnd();
    }
}