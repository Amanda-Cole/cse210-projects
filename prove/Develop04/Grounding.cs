public class Grounding : Activity
{
    private string _nextPrompt;
    private int i = 0;
    List<string> _libListGrounded = new List<string>();

    public Grounding()
    :base( "Grounding Activity", "This activity will help you relax by focusing on parts of your body. (Recommend 45 Seconds)")
    {
        _libListGrounded.Add("Focus on wiggling your toes and stretching your ankles....");
        _libListGrounded.Add("Focus on rotating your wrists....");
        _libListGrounded.Add("Focus on stretching your neck by putting your left ear to your left shoulder....");
        _libListGrounded.Add("Focus on stretching your neck by putting your right ear to your right shoulder.....");
        _libListGrounded.Add("Focus on stretching your neck by looking down.....");
        _libListGrounded.Add("Focus on stretching your neck by looking up....");
        _libListGrounded.Add("Focus on shrugging and relaxing your shoulders....");
    }

    public override void DisplayActivity()
    {
        base.DisplayActivity();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(Duration);

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            _nextPrompt = _libListGrounded[i];
            Console.Write(_nextPrompt);
            TimerDown(6);
            Console.Write("\b \b");
            Console.WriteLine();
            i++;
            currentTime = DateTime.Now;
        }
        DisplayEnd();
    }
}