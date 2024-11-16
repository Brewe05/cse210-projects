using System;

class Program
{
    static void Main()
    {
        // Call DisplayWelcome to show the welcome message
        DisplayWelcome();

        // Call PromptUserName and save the returned name
        string userName = PromptUserName();

        // Call PromptUserNumber and save the returned number
        int userNumber = PromptUserNumber();

        // Call SquareNumber with the user's number and save the result
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult with the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to accept an integer and return its square
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
