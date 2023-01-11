using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number between 1-10? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guessNumber = -1;
        // string playon = "yes";

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess between 1-100? ");
            guessNumber =int.Parse(Console.ReadLine());
            

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}