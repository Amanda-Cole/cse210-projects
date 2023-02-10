using System;

public class Word{
    private string _word;
    private string _hiddenWord;
    private bool _isShown;

    public Word(string wordText){
        _word = wordText;
        string replaceText = "";
        for (int i = 0; i < _word.Length; i++){
            replaceText += '_';
        }
        _hiddenWord = replaceText;
        _isShown = true;
    }
    public void HideWord(){
        _isShown = false;
    }
    public bool IsHidden()
    {
        return !_isShown;
    }
    public bool IsShown()
    {
        return _isShown;
    }
    public string GetWordText(bool showOriginalText)
    {
        if(IsHidden() && !showOriginalText){
            return _hiddenWord;
        } 
        return _word;
    }
}
