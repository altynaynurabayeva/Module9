using System;

public class RoomBookingSystem
{
    public void BookRoom(string guestName)
    {
        Console.WriteLine($"Room booked for {guestName}.");
    }

    public void CancelBooking(string guestName)
    {
        Console.WriteLine($"Booking cancelled for {guestName}.");
    }
}
