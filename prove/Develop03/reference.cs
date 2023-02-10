using System;
using System.IO;

public class Reference
{
    private string _verse1;
    private string _bookName;
    private string _chapter;
    private string _endverse;
    public Reference(){}

    public Reference(string bookName,string chapter, string verse1){
// setter
    _bookName = bookName;
    _verse1 = verse1;
    _chapter = chapter;
    _endverse = "";
    }
    public Reference(string bookName, string chapter, string verse1, string endverse){
        _bookName = bookName;
        _verse1 = verse1;
        _chapter = chapter;
        _endverse = endverse;
    }
    public string GetReferenceText()
    {
        string refText = $"{_bookName} {_chapter}:{_verse1}";
        if (_endverse.Length >0)
        {
            refText = refText + $"-{_endverse}";
            //Console.Write($"{_endverse}");
        }
        return refText;
    }
}