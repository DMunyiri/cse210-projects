using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    /// <summary>
    /// Adds a new entry to the journal.
    /// </summary>
    /// <param name="entry">The entry to add.</param>
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    /// <summary>
    /// Displays all entries in the journal.
    /// </summary>
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    /// <summary>
    /// Saves the journal to a file in JSON format.
    /// </summary>
    /// <param name="filename">The filename to save the journal to.</param>
    public void SaveToFile(string filename)
    {
        try
        {
            // Serialize the list of entries to JSON with indentation
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
            Console.WriteLine($"Journal saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    /// <summary>
    /// Loads the journal from a file in JSON format.
    /// </summary>
    /// <param name="filename">The filename to load the journal from.</param>
    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                // Read the JSON content from the file
                string json = File.ReadAllText(filename);

                // Deserialize the JSON into a list of Entry objects
                _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
                Console.WriteLine($"Journal loaded from {filename}.");
            }
            else
            {
                Console.WriteLine("File does not exist. Starting with an empty journal.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}