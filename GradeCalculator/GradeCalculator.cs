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
         int examScore = Score();
        Console.WriteLine("Your Exam Score is: " + examScore);
        string examGrade = Grade(examScore); 
        Console.WriteLine("Your Grade is: " + examGrade);

    }
    static int Score()
    {
        Console.Write("Please Enter Your Exam Score: ");
        string input = Console.ReadLine();
        int examScore = int.Parse(input);
        return examScore;
    }
    static string Grade(int score)
    {
        if (score >= 90)
            return "A";
        else if (score >= 80)
            return "B";
        else if (score >= 70)
            return "C";
        else if (score >= 60)
            return "D";
        else
            return "F";
    }
}
