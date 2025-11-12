using System;

public class Employee : OrganizationComponent
{
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string position, double salary) : base(name)
    {
        Position = position;
        Salary = salary;
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + $" {Position}: {_name}, Salary: {Salary}");
    }

    public override double GetBudget() => Salary;
    public override int GetEmployeeCount() => 1;
}
