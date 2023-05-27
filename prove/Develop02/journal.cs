using System;

namespace Develop02;

class Journal
{
    List<Entry>_entries;


    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public 
        List<Entry> GetEntries()
        {
            return _entries;
        }
}