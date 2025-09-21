public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    // Converts entry to a format suitable for saving to a file
    public string ToFileFormat()
    {
        // Use a pipe | as a safe delimiter
        return $"{Date}|{Prompt}|{Response}";
    }

    // Parses a file line into an Entry object
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');

        // Handle possible file corruption or format issues gracefully
        if (parts.Length < 3)
        {
            return new Entry("Invalid Date", "Invalid Prompt", "Corrupt or incomplete entry.");
        }

        return new Entry(parts[0], parts[1], parts[2]);
    }
}
