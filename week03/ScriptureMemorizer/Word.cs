using System;

public class Word 
{
    private string _text{get;}
    private bool _isHidden{get; set;}

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }


    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}