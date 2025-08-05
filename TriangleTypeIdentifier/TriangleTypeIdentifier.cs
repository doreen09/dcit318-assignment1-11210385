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
    {
        Console.Write("Please enter the length of side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length of side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length of side 3: ");
        int side3 = int.Parse(Console.ReadLine());
    }
}