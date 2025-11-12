using System;

public abstract class OrganizationComponent
{
    protected string _name;
    public OrganizationComponent(string name) { _name = name; }
    public abstract void Display(int depth);
    public abstract double GetBudget();
    public abstract int GetEmployeeCount();
}
