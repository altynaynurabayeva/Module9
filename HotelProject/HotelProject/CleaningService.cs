using System;

public class CleaningService
{
    public void ScheduleCleaning(string room)
    {
        Console.WriteLine($"Cleaning scheduled for {room}.");
    }

    public void RequestImmediateCleaning(string room)
    {
        Console.WriteLine($"Immediate cleaning requested for {room}.");
    }
}
