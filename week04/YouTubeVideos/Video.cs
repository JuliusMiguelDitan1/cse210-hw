using System;

public class Video{
    string _tittleName;
    string _authorName;
    double _length;

    public List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, double length) 
    {
        _tittleName = title;
        _authorName = author;
        _length = length;

    }

    public void Display() 
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine(_tittleName);
        Console.WriteLine(_length);
        Console.WriteLine(_authorName);
        Console.WriteLine("---------------------");
        Console.WriteLine("Comments");
        foreach (Comment i in _comment)
        {
            Console.WriteLine();
            i.Display();
        }
    }


}

