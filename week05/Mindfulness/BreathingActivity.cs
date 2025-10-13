using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) 
        : base(name, description) { }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(6);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}
