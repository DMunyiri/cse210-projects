using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
    }

    public bool HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Find all unhidden words
        var unhiddenWords = _words.Where(w => !w.GetDisplayText().Contains('_')).ToList();

        if (unhiddenWords.Count == 0)
            return false;

        // Randomly hide words
        while (hiddenCount < count && unhiddenWords.Count > 0)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            hiddenCount++;
            unhiddenWords.RemoveAt(index);
        }

        return true;
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(w => w.GetDisplayText().Contains('_'));
    }
}