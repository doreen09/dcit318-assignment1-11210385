using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int priceOfTicket;

        if (age <= 12 || age >= 65)
        {
            priceOfTicket = 7;
        }
        else
        {
            priceOfTicket = 10;
        }

        Console.WriteLine("Your ticket price is: GHC" + priceOfTicket);
    }
}
