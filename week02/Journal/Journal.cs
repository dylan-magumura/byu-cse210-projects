using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Adds a new journal entry to the list
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Displays all entries in the journal
    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    // Saves all entries to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.ToFileFormat());
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving to file: {e.Message}");
        }
    }

    // Loads entries from a file and replaces current entries
    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                _entries.Clear();
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Entry entry = Entry.FromFileFormat(line);
                    _entries.Add(entry);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading from file: {e.Message}");
        }
    }
}
