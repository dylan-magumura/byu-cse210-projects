//for extra credit i added a gratitude activity
using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing."
                    );
                    break;

                case "2":
                    activity = new ReflectingActivity(
                        "Reflecting Activity",
                        "This activity will help you reflect on times when you have shown strength and resilience."
                    );
                    break;

                case "3":
                    activity = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area."
                    );
                    break;

                case "4":
                    activity = new GratitudeActivity(
                        "Gratitude Activity",
                        "This activity will help you reflect on things you are grateful for. (Extra Credit)"
                    );
                    break;

                case "5":
                    quit = true;
                    continue;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            activity.Run();

            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }

        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
    }
}

