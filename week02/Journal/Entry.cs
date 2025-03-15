using System;
// Based on code in this websites https://stackoverflow.com/questions/77238547/vs-code-simple-console-journal-program-issue
// different but still based on the code on the websites
public class Entry {
public string _date;
public string _prompt;
public string _answer;

    public void DisplayAll()
    {
        Console.WriteLine($"Date: {_date};");
         Console.WriteLine($"Prompt: {_prompt}\n");
        Console.WriteLine($"Content: {_answer}\n");
    }

}