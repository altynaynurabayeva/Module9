using System;

public class HotelFacade
{
    private RoomBookingSystem _roomBooking = new RoomBookingSystem();
    private RestaurantSystem _restaurant = new RestaurantSystem();
    private EventManagementSystem _events = new EventManagementSystem();
    private CleaningService _cleaning = new CleaningService();
    private TaxiService _taxi = new TaxiService();

    public void BookRoomWithServices(string guestName)
    {
        Console.WriteLine("\n--- Booking Room with Services ---");
        _roomBooking.BookRoom(guestName);
        _restaurant.OrderFood(guestName, "Pasta");
        _cleaning.ScheduleCleaning("Room 101");
    }

    public void OrganizeEventWithRooms(string eventName)
    {
        Console.WriteLine("\n--- Organizing Event ---");
        _events.OrganizeEvent(eventName);
        _events.BookEquipment("Projector");
        _roomBooking.BookRoom("Participants of " + eventName);
    }

    public void BookRestaurantWithTaxi(string guestName)
    {
        Console.WriteLine("\n--- Booking Restaurant with Taxi ---");
        _restaurant.BookTable(guestName);
        _taxi.BookTaxi(guestName);
    }

    public void CancelAll(string guestName)
    {
        Console.WriteLine("\n--- Cancelling All Bookings ---");
        _roomBooking.CancelBooking(guestName);
        Console.WriteLine("All related services cancelled.");
    }
}
