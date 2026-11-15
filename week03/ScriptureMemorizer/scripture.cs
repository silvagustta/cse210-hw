using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string text = string.Join(" ", displayWords);

        return $"{_reference.GetDisplayText()} {text}";
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        List<int> visibleWords = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWords.Add(i);
            }
        }

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);

            int wordIndex = visibleWords[randomIndex];

            _words[wordIndex].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}