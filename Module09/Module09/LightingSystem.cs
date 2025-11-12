using System;

public class LightingSystem
{
    public void TurnOn() => Console.WriteLine("Lights are turned on.");
    public void SetBrightness(int level) => Console.WriteLine($"Lights brightness is set to {level}.");
    public void TurnOff() => Console.WriteLine("Lights are turned off.");
}
