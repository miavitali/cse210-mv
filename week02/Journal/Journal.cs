using System;
using System.Collections.Generic;
using System.IO;

// MODIFIED:
// - Updated LoadFromFile() to use the new FromCsvString() method instead of basic splitting.
// - Now supports loading entries that include commas, quotes, and line breaks within fields.

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromCsvString(line);
            _entries.Add(entry);

        }
    }
}
