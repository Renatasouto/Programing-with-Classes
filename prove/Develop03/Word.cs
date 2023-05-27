public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return this._text;
    }

    public void SetText(string text)
    {
        this._text = text;
    }

    public bool GetIsHidden()
    {
        return this._isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        this._isHidden = isHidden;
    }
}
