
public class ScriptureReference
{
    private string _bookName;
    private int _chapterNumber;
    private int _startVerse;
    private int? _endVerse;

    public ScriptureReference(string bookName, int chapterNumber, int startVerse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startVerse = startVerse;
        if (!IsValid()){
            throw new ArgumentException("Invalid scripture reference");
        }
    }

    public ScriptureReference(string bookName, int chapterNumber, int startVerse, int endVerse)
        : this(bookName, chapterNumber, startVerse)
    {
        _endVerse = endVerse;
        if (!IsValid()){
            throw new ArgumentException("Invalid scripture reference");
        }
    }

    public string GetReferenceString()
    {
        return _endVerse == null
            ? $"{_bookName} {_chapterNumber}:{_startVerse}"
            : $"{_bookName} {_chapterNumber}:{_startVerse}-{_endVerse}";
    }

    public bool IsValid()
    {
        if (string.IsNullOrEmpty(_bookName))
            return false;

        if (_chapterNumber <= 0)
            return false;

        if (_startVerse <= 0)
            return false;

        if (_endVerse.HasValue && (_endVerse.Value <= 0 || _endVerse.Value < _startVerse))
            return false;

        return true;
    }

    //getters and setters
    public string GetBookName()
    {
        return this._bookName;
    }

    public void SetBookName(string bookName)
    {
        this._bookName = bookName;
    }

    public int GetChapterNumber()
    {
        return this._chapterNumber;
    }

    public void SetChapterNumber(int chapterNumber)
    {
        this._chapterNumber = chapterNumber;
    }

    public int GetStartVerse()
    {
        return this._startVerse;
    }

    public void SetStartVerse(int startVerse)
    {
        this._startVerse = startVerse;
    }

    public int? GetEndVerse()
    {
        return this._endVerse;
    }

    public void SetEndVerse(int? endVerse)
    {
        this._endVerse = endVerse;
    }

}
