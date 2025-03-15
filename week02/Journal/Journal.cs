using System;
// Based on code in this websites https://stackoverflow.com/questions/77238547/vs-code-simple-console-journal-program-issue
// Additionally, this code is not working as intended and needs refinement but is still based upon the codes.
public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator promptGenerator;
    public Journal() 
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();

    }
    public void AddEntry()
    {
        Entry ent = new Entry();
        string prompt = promptGenerator.GenerateRandomPrompt();
        Console.Write("The date today: ");
        String date = Console.ReadLine();
        ent._date = date;
        Console.WriteLine(prompt);
        Console.Write("> ");
        string content =  Console.ReadLine();
        ent._answer= content;
        ent._prompt = prompt;
        _entries.Add(ent);
        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayAll();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in _entries) {
                    writer.WriteLine($"{entry._date}\n{entry._prompt}\n{entry._answer}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
    }
    public void LoadFromFile()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    string dateString = reader.ReadLine();
                    string pro = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry ent = new Entry();
                    ent._date = dateString;
                    ent._prompt = pro;
                    ent._answer = content;
                    _entries.Add(ent);
                }
            } 
        } catch (Exception e) {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }
}