public class Activity
{
    // set attributes
    private string _startMessage ="Welcome to the ";
    private string _endMessage = "Well Done!!";
    private int _duration = 0;
    private string _activityName = "";
    private string _activityDescription = "";

// getter
    protected int Duration{
        get{
            return _duration;
        }
    }
    protected string ActivityName{
        get{
            return _activityName;
        }
    }
    protected string ActivityDescription{
        get{
            return _activityDescription;
        }
    }

// constructor
    public Activity (string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine( _startMessage + _activityName);
        Console.WriteLine();
        Spinner(3);
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Spinner(3);
        Console.Write("How long, in seconds, would you like for your session?  ");
        _duration = int.Parse(Console.ReadLine());
        Spinner(3);
        Console.WriteLine();
        Console.Write("You will begin in..... ");
        TimerDown(3);
        Console.Write("\b \b");
        Console.Clear();
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        Console.WriteLine();
        Console.WriteLine($"You completed {Duration} seconds of the {ActivityName}" ) ;
        Spinner(3);
        Thread.Sleep(3000);
        Console.Clear();
    }

    public virtual void DisplayActivity(){
        DisplayWelcomeMessage();
    }
    public virtual void DisplayEnd(){
        DisplayEndMessage();
    }
    public void Spinner(int a)
    {
        int numb = 0;
        do{
            Console.Write('|');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('/');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('-');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            numb+=1;
        } while(numb !=a);
    }
    public void TimerDown(int a){
        while ( a >=0)
        {          
            Console.Write("\b \b");
            Console.Write(a);
            System.Threading.Thread.Sleep(1000);
            a--;
        }
    }
    public void TimerUp(){
        int a =0;
        while (a <=4)
        {
            Console.Write("\b \b");
            Console.Write(a);
            System.Threading.Thread.Sleep(1000);
            a++;
        }
    }
    public string GetRandomPrompt(List<string> prompts){
        Random r = new Random();
        int index = r.Next(0, prompts.Count);
        return prompts[index];
    }
}  
