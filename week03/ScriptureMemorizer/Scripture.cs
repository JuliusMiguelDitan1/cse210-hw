using System;

public class Scripture
{
    public Reference _reference;
    public List<Word> _word;

    private int i = 0;
    

     List<int> listNumbers = new List<int>();

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
        if (i <= _word.Count)
        {
           var rand = new Random();
            int number;
                do {
                        number = rand.Next(0,  _word.Count);
                } while (listNumbers.Contains(number)); {
                    listNumbers.Add(number);
                }
            _word[listNumbers[i]].Hide();
             i++;
            
        }
    } 

    public bool IsCompletelyHidden()
    {
        int t = _word.Count;
        return i >= t;
    }
    public string Displayall() 
    {
        string renderedText = string.Join(" ", _word);
        return $"{_reference.GetDisplay()}: {renderedText} {i} {_word.Count} {listNumbers.Count}";
    }
}