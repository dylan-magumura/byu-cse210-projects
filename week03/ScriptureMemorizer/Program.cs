using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scriptures = new Scripture[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(scriptures.Length)];

        while (!currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            currentScripture.HideRandomWords(3);
        }
        
        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
        
    }
}