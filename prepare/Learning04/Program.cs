using System;

class Program
{
    static void Main(string[] args)
    {
        // create simple assignment and call method to get summary
        Assignment a1 = new Assignment("Amanda Cole","Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment ("Caleb Cole", "trig" ,"8.5","19-25");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        
        WritingAssignment a3 = new WritingAssignment("London Cole", "WW2","Hitler Scary");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingAssignment());
    }
}