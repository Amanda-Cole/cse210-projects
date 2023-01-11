using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // declare list
        List<int> numbers = new List<int>();

        // Initialize variable
        int userNumber = -1;

        // while loop so that multiple numbers can be added to the list
        while (userNumber!=0)
        {
            Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        // take input and convert from string to int 
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

        // add userNumber to list if it doesn't equal 0
            if (userNumber != 0)
            {
                // adding userNumber (input) to numbers list
                numbers.Add(userNumber);
            } 
        }

        //  Part 1: compute sum of all numbers in the list

        // initialize sum variable
        int sum = 0;

        // for each number in numbers list compute sum
        foreach (int number in numbers)
        {
            sum += number;
        }
        // print sum
        Console.WriteLine($"The sum is: {sum}");

// Part 2: Compute the average
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though it puts the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.

        // take the sum - convert to a float for decimals / divide by the count of the list - labaled new variable average

        float average = ((float)sum) / numbers.Count;
        // print average
        Console.WriteLine($"The Average is: {average}");

        // Part 3: find the max

        Console.WriteLine("Max is " + numbers.Max());




    }
}