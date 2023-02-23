public class Listing :Activity
{
    private int _countList = 0;
    private string _answer="";
    List<string> _listReceived = new List<string>();
    List<string> _libListPrompts = new List<string>();
    public Listing():base("Listing Exercise","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _libListPrompts.Add("Who are people that you appreciate?");
        _libListPrompts.Add("What are personal strengths of yours?");
        _libListPrompts.Add("Who are people that you have helped this week?");
        _libListPrompts.Add("When have you felt the Holy Ghost this month?");
        _libListPrompts.Add("Who are some of your personal heroes?");
    }
    public override void DisplayActivity()
    {
        base.DisplayActivity();
        Console.WriteLine (GetRandomPrompt(_libListPrompts)); 
        Console.WriteLine();
        Thread.Sleep(1500);
        Console.WriteLine($"You will have {Duration} seconds to list as many things as you can.");
        Console.WriteLine();
        Console.WriteLine("You may begin writing now.");

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(Duration);

        while (currentTime < futureTime)
        {
            Console.Write("<");
            _answer = Console.ReadLine();
            _listReceived.Add(_answer);
            currentTime = DateTime.Now;
        }

        _countList = _listReceived.Count();
        Console.WriteLine();
        Console.WriteLine($"You listed {_countList} items");

        DisplayEnd();
    }      
}