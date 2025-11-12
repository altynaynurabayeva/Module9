using System;

class Program
{
    static void Main()
    {
       
        //  FACADE 
        
        /*
        HotelFacade hotel = new HotelFacade();

        hotel.BookRoomWithServices("Altynai");
        hotel.OrganizeEventWithRooms("FinTech Conference");
        hotel.BookRestaurantWithTaxi("Altynai");
        hotel.CancelAll("Altynai");
        */

        // COMPOSITE 
        
        Department headOffice = new Department("Head Office");
        Department itDept = new Department("IT Department");
        Department hrDept = new Department("HR Department");

        Employee e1 = new Employee("Aigerim", "Developer", 300000);
        Employee e2 = new Employee("Diana", "System Analyst", 280000);
        Employee e3 = new Employee("Malika", "HR Manager", 250000);

        itDept.Add(e1);
        itDept.Add(e2);
        hrDept.Add(e3);

        headOffice.Add(itDept);
        headOffice.Add(hrDept);

        Console.WriteLine("\n=== Composite Demo (Organization Structure) ===");
        headOffice.Display(1);
        Console.WriteLine($"\nTotal Employees: {headOffice.GetEmployeeCount()}");
        Console.WriteLine($"Total Budget: {headOffice.GetBudget()} KZT");
    }
}
