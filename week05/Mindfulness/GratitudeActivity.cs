using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are three things you are grateful for today?",
        "Who in your life are you thankful for and why?",
        "Think about a challenge that helped you grow—what gratitude can you find in it?",
        "What simple things (like sunshine or laughter) bring you joy?"
    };

    public GratitudeActivity(string name, string description) 
        : base(name, description) { }

    public override void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Take a moment to think about your answers...");
        ShowSpinner(5);

        List<string> responses = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} things you’re grateful for!");
        DisplayEndingMessage();
    }
}
