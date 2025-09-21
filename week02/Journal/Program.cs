using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the user's name 
        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        // Welcome message
        Console.WriteLine($"\nWelcome to Your Daily Journal, {name}!");

        Journal journal = new Journal(); // create Journal instance
        PromptGenerator promptGenerator = new PromptGenerator(); // prompt generator

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Entries");
            Console.WriteLine("4. Save Entries");
            Console.WriteLine("5. Quit");

            Console.Write("Please select an option (1-5): ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }
            else if (option == "2")
            {
                Console.WriteLine("\nYour Journal Entries:");
                journal.DisplayJournal();
            }
            else if (option == "3")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Entries loaded.");
            }
            else if (option == "4")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Entries saved.");
            }
            else if (option == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
            }
        }
    }
}
