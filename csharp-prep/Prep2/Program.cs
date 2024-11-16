using System;

class Program
{
    static void Main()
    {
        // Get the grade percentage from user
        Console.Write("Enter your grade percentage: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        // Assigning a letter to the grade percentage
        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check for passing grade
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, keep trying and you'll do better next time!");
        }

        int lastDigit = (int)gradePercentage % 10;

        //Determining the sign associated with the grade
        string sign = "";
        if (letter != "A" && letter != "F") // Handle special cases for A and F grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
