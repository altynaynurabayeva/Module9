using System;

public class RestaurantSystem
{
    public void BookTable(string guestName)
    {
        Console.WriteLine($"Table booked at the restaurant for {guestName}.");
    }

    public void OrderFood(string guestName, string dish)
    {
        Console.WriteLine($"{guestName} ordered {dish}.");
    }
}
