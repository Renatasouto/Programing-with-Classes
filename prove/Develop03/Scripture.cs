public class Scripture
{
    private ScriptureReference _scriptureReference;
    private List<Word> _words;
    private static Random _rand = new Random();

    public Scripture(ScriptureReference scriptureReference, List<Word> words)
    {
        _scriptureReference = scriptureReference;
        _words = words;
    }

    // Methods to display and hide scripture words
    public void HideRandomWord()
    {
        var notHiddenWords = _words.Where(w => !w.GetIsHidden()).ToList();
        if (notHiddenWords.Any())
        {
            var randomWord = notHiddenWords[_rand.Next(notHiddenWords.Count)];
            randomWord.SetIsHidden(true);
        }
    }

    public string DisplayScripture(){
        var scriptureText = String.Join(' ', _words.Select(w => w.GetIsHidden() ? new String('_', w.GetText().Length) : w.GetText()));
        return $"{_scriptureReference.GetReferenceString()} {scriptureText} \n";
    }

    //getters and setters
    public ScriptureReference GetScriptureReference()
    {
        return this._scriptureReference;
    }

    public void SetScriptureReference(ScriptureReference reference)
    {
        this._scriptureReference = reference;
    }

    public List<Word> GetWords()
    {
        return this._words;
    }

    public void SetWords(List<Word> words)
    {
        this._words = words;
    }
}
