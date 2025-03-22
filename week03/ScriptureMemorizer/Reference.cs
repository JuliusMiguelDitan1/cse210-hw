using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startverse, int endverse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = startverse;
        _endVerse = endverse;
    }

    public string GetDisplay()
    {
        string a = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return a;
    }
}