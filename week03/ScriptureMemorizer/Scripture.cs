using System;

public class Scripture
{
    public Reference _reference;
    public List<Word> _word;

    private int i = 0;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _word.Add(new Word(word));
        }
    }

   public void HideRandomWords()
    {
        if (i < _word.Count)
        {
            Random random = new Random();
            int index = random.Next(0,_word.Count);
            _word[index].Hide();
             i++;
            
        }
    } 

    public bool IsCompletelyHidden()
    {
        return i >= _word.Count;
    }
    public string Displayall() 
    {
        string renderedText = string.Join(" ", _word);
        return $"{_reference.GetDisplay()}: {renderedText} {i} {_word.Count}";
    }
}