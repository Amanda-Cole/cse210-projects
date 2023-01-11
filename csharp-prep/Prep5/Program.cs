using System;

class Program
{

    static void Main(string[] args)
    // function Main
    {
        // Initialize function DisplayWelcomeMessage
        DisplayWelcomeMessage();

        // set variable return for function PromptUserName and PromptUserNumber
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        // set variable return for function SquareNumber using the userNumber
        int squaredNumber = SquareNumber(userNumber);

        // Initialize function DisplayResult with parameters of userName and userNumber
        DisplayResult(userName,squaredNumber);
    }
// Defining the functions that are called in Main
    static  void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your Name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
   
}