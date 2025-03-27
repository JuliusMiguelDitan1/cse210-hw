using System;

public class Comment {
    string _commentText;
    string _personName;

    public Comment(string Name, string Text)
    {
        _commentText = Text;
        _personName = Name;
    }

    public void Display()
    {
        Console.WriteLine($"{_personName}:\n{_commentText}.");
    }

}