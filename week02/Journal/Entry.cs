using System;
using System.Collections.Generic;

// MODIFIED:
// - Added a new "Mood" field to the Entry class, included in the constructor and overall structure.
// - Updated ToFileString() to include the Mood and format all fields as standard CSV, escaping commas, double quotes, and line breaks properly.
// - Added FromCsvString() to parse properly formatted CSV lines, handling quoted fields with special characters.

public class Entry
{
    private string _date;
    private string _mood;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string mood, string promptText, string entryText)
    {
        _date = date;
        _mood = mood;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    private string EscapeCsvField(string field)
    {
        if (field.Contains("\""))
            field = field.Replace("\"", "\"\"");

        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            field = $"\"{field}\"";

        return field;
    }

    public string ToFileString()
    {
        return $"{EscapeCsvField(_date)},{EscapeCsvField(_mood)},{EscapeCsvField(_promptText)},{EscapeCsvField(_entryText)}";
    }

    public static Entry FromCsvString(string line)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        string currentField = "";

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (c == '\"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                {
                    currentField += '\"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(currentField);
                currentField = "";
            }
            else
            {
                currentField += c;
            }
        }
        fields.Add(currentField);

        if (fields.Count != 4)
            throw new FormatException("La línea CSV no tiene el número correcto de campos.");

        return new Entry(fields[0], fields[1], fields[2], fields[3]);
    }
}
