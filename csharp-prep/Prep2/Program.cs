using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int percentage = int.Parse(number);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if (percentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string passed = "";

        if (percentage >= 70)
        {
            passed = "You passed!";
        }
        else
        {
            passed = "You FAILED.";
        }


        string symbol = " ";

        if (percentage > 98)
        {
            symbol = " ";
        }
        else if (percentage < 60)
        {
            symbol = " ";
        }
        else
        {
            int remainder = percentage%10;
            if (remainder >= 7)
            {
                symbol = "+";
            }
            else if (remainder <3)
            {
                symbol = "-";
            }
        }


        Console.WriteLine($"Your grade is a {letter}{symbol} for the class.");
        Console.WriteLine($"{passed}");
        



    }
}