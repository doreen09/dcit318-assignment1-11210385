using System;
/* This program  prompts the user to enter a numerical grade between 0 and 100. Based 
on the grade entered, it displays the corresponding letter grade using the following scale:
90 and above: A
80-89: B 
70-79: C 
60-69: D 
Below 60: F */

class GradeCalculator
{
    static void Main()
    {
        
        Console.WriteLine("Your Exam Score is: " + Score());

    }
    static int Score()
    {
        Console.Write("Please Enter Your Exam Score: ");
        string input = Console.ReadLine();
        int examScore = int.Parse(input);
        return examScore;
    }
}
