public class Reference
{
    private string _book;
    private int _startVerse;
    private int? _endVerse;

    // Constructor for single verse
    public Reference(string book, int verse)
    {
        _book = book;
        _startVerse = verse;
        _endVerse = null;
    }

    // Constructor for verse range
    public Reference(string book, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{_book} {_startVerse}-{_endVerse}"
            : $"{_book} {_startVerse}";
    }
}