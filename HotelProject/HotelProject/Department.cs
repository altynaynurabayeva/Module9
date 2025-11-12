using System;
using System.Collections.Generic;

public class Department : OrganizationComponent
{
    private List<OrganizationComponent> _components = new List<OrganizationComponent>();

    public Department(string name) : base(name) { }

    public void Add(OrganizationComponent component) => _components.Add(component);
    public void Remove(OrganizationComponent component) => _components.Remove(component);

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Department: " + _name);
        foreach (var c in _components)
            c.Display(depth + 2);
    }

    public override double GetBudget()
    {
        double total = 0;
        foreach (var c in _components)
            total += c.GetBudget();
        return total;
    }

    public override int GetEmployeeCount()
    {
        int count = 0;
        foreach (var c in _components)
            count += c.GetEmployeeCount();
        return count;
    }
}
