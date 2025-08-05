/*
THE TRIANGLE TYPE IDENTIFIER
This program that prompts the user to enter three sides of a triangle. Based on the lengths 
of the sides entered, determine and display the type of the triangle. 
The possible types are: - 
Equilateral: All three sides are equal. 
Isosceles: Two sides are equal. 
Scalene: No sides are equal. 
*/

class TriangleType
{
    static void Main()
//User Input Logic
    {
        Console.Write("Please enter the length of side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length of side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length of side 3: ");
        int side3 = int.Parse(Console.ReadLine());

//Calculating the sides
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an Equilateral triangle.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("This is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("This is a Scalene triangle.");
        }
    }
}