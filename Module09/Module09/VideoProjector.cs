using System;

public class VideoProjector
{
    public void TurnOn() => Console.WriteLine("Video projector is turned on.");
    public void SetResolution(string resolution) => Console.WriteLine($"Video resolution is set to {resolution}.");
    public void TurnOff() => Console.WriteLine("Video projector is turned off.");
}
