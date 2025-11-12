using System;

public class EventManagementSystem
{
    public void OrganizeEvent(string eventName)
    {
        Console.WriteLine($"Event '{eventName}' has been organized.");
    }

    public void BookEquipment(string equipment)
    {
        Console.WriteLine($"{equipment} has been booked for the event.");
    }
}
